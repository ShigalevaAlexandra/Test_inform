--Создание таблицы _STUDENTS_
CREATE TABLE students (
    id_student INT PRIMARY KEY IDENTITY(1, 1),
	student_name VARCHAR(50) NOT NULL,
	student_surname VARCHAR(50) NOT NULL,
	student_group VARCHAR(10) NOT NULL,
)
--DROP TABLE students;

--Создание таблицы _QUESTIONS_
CREATE TABLE questions (
    id_question INT PRIMARY KEY IDENTITY(1, 1),
	question_text VARCHAR(100) NOT NULL,
	first_answer_id INT NOT NULL,
	second_answer_id INT NOT NULL,
	third_answer_id INT NOT NULL,
	right_answer VARCHAR(100) NOT NULL,
)
--DROP TABLE questions;

--Создание таблицы _FIRST_ANSWERS_
CREATE TABLE first_answers (
    id_first_answer INT PRIMARY KEY IDENTITY(1, 1),
	first_answer_text VARCHAR(100) NOT NULL,
)
--DROP TABLE first_answers;

--Создание таблицы _SECOND_ANSWERS_
CREATE TABLE second_answers (
    id_second_answer INT PRIMARY KEY IDENTITY(1, 1),
	second_answer_text VARCHAR(100) NOT NULL,
)
--DROP TABLE second_answers;

--Создание таблицы _THIRD_ANSWERS_
CREATE TABLE third_answers (
    id_third_answer INT PRIMARY KEY IDENTITY(1, 1),
	third_answer_text VARCHAR(100) NOT NULL,
)
--DROP TABLE third_answers;

--Создание таблицы _RESULTS_
CREATE TABLE results (
    id_result INT PRIMARY KEY IDENTITY(1, 1),
	student_id INT NOT NULL,
	student_result INT NOT NULL,
)
--DROP TABLE results;

---------------------------------------------------------------------

--Создание связи _STUDENTS_/_RESULTS_
ALTER TABLE results
ADD CONSTRAINT fk_student
FOREIGN KEY (student_id)
REFERENCES students (id_student)
ON DELETE CASCADE;

--Создание связи _FIRST_ANSWERS_/_QUESTIONS_
ALTER TABLE questions
ADD CONSTRAINT fk_first_answer
FOREIGN KEY (first_answer_id)
REFERENCES first_answers (id_first_answer)
ON DELETE CASCADE;

--Создание связи _SECOND_ANSWERS_/_QUESTIONS_
ALTER TABLE questions
ADD CONSTRAINT fk_second_answer
FOREIGN KEY (second_answer_id)
REFERENCES second_answers (id_second_answer)
ON DELETE CASCADE;

--Создание связи _THIRD_ANSWERS_/_QUESTIONS_
ALTER TABLE questions
ADD CONSTRAINT fk_third_answer
FOREIGN KEY (third_answer_id)
REFERENCES third_answers (id_third_answer)
ON DELETE CASCADE;

---------------------------------------------------------------------

--Добавление данных в _QUESTIONS_
INSERT INTO questions (question_text, first_answer_id, second_answer_id, third_answer_id, right_answer) VALUES
('Для вывода графической информации в ПК используется:', 1, 1, 1, 'экран дисплея'),
('Графика с представлением изображения в виде совокупностей точек называется:', 2, 2, 2, 'растровой'),
('Что собой представляет компьютерная графика?', 3, 3, 3, 'графическме элементы программ, а также технология их обработки'),
('Какие из перечисленных форматов принадлежат графическим файлам?', 4, 4, 4, '*.gif, *.jpg'),
('Какой тип графического изображения вы будете использовать при редакировании цифровой фотографии?', 5, 5, 5, 'ратровое изображение'),
('Архитектура компьютера - это', 6, 6, 6, 'техническое описание деталей устройств компьютера'),
('Постоянное запоминающее устройство служит для хранения:', 7, 7, 7, 'программ начальной загрузки ПК и тестирования его узлов'),
('Драйвер - это', 8, 8, 8, 'программа, управляющая конкретным внешнм устройством'),
('Большинство антивирусных рограмм выявляют вирусы по', 9, 9, 9, 'образцам их программного кода'),
('Устройство ввода информации с листа бумаги называется:', 10, 10, 10, 'сканер')

--Добавление данных в _FIRST_ANSWERS_
INSERT INTO first_answers (first_answer_text) VALUES
('мышь'),
('фрактальной'),
('набор файлов графических форматов'),
('*.doc, *.txt'),
('ратровое изображение'),
('техническое описание деталей устройств компьютера'),
('особо ценных документов'),
('устройство длительного хранения информации'),
('алгоритмам маскировки'),
('сканер')

--Добавление данных в _SECOND_ANSWERS_
INSERT INTO second_answers (second_answer_text) VALUES
('клавиатура'),
('растровой'),
('дизайн Web-сайтов'),
('*.wav, *.mp3'),
('векторное изображение'),
('описание устройств для ввода-вывода информации'),
('постоянно используемых программ'),
('программа, управляющая конкретным внешнм устройством'),
('образцам их программного кода'),
('плоттер')

--Добавление данных в _THIRD_ANSWERS_
INSERT INTO third_answers (third_answer_text) VALUES
('экран дисплея'),
('векторной'),
('графическме элементы программ, а также технология их обработки'),
('*.gif, *.jpg'),
('фрактальное изображение'),
('описание ПО для работы компьютера'),
('программ начальной загрузки ПК и тестирования его узлов'),
('устройство вывода информации'),
('разрушающему воздействию'),
('стример')

---------------------------------------------------------------------

--Создание представления _ALL_RESULT_
CREATE VIEW all_result AS
SELECT students.student_name AS name_,
       students.student_surname AS surname_,
	   students.student_group AS group_,
	   results.student_result AS result_
FROM results INNER JOIN students ON results.student_id = students.id_student

--SELECT * FROM all_result;