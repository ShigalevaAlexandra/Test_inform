--�������� ������� _STUDENTS_
CREATE TABLE students (
    id_student INT PRIMARY KEY IDENTITY(1, 1),
	student_name VARCHAR(50) NOT NULL,
	student_surname VARCHAR(50) NOT NULL,
	student_group VARCHAR(10) NOT NULL,
)
--DROP TABLE students;

--�������� ������� _QUESTIONS_
CREATE TABLE questions (
    id_question INT PRIMARY KEY IDENTITY(1, 1),
	question_text VARCHAR(100) NOT NULL,
	first_answer_id INT NOT NULL,
	second_answer_id INT NOT NULL,
	third_answer_id INT NOT NULL,
	right_answer VARCHAR(100) NOT NULL,
)
--DROP TABLE questions;

--�������� ������� _FIRST_ANSWERS_
CREATE TABLE first_answers (
    id_first_answer INT PRIMARY KEY IDENTITY(1, 1),
	first_answer_text VARCHAR(100) NOT NULL,
)
--DROP TABLE first_answers;

--�������� ������� _SECOND_ANSWERS_
CREATE TABLE second_answers (
    id_second_answer INT PRIMARY KEY IDENTITY(1, 1),
	second_answer_text VARCHAR(100) NOT NULL,
)
--DROP TABLE second_answers;

--�������� ������� _THIRD_ANSWERS_
CREATE TABLE third_answers (
    id_third_answer INT PRIMARY KEY IDENTITY(1, 1),
	third_answer_text VARCHAR(100) NOT NULL,
)
--DROP TABLE third_answers;

--�������� ������� _RESULTS_
CREATE TABLE results (
    id_result INT PRIMARY KEY IDENTITY(1, 1),
	student_id INT NOT NULL,
	student_result INT NOT NULL,
)
--DROP TABLE results;

---------------------------------------------------------------------

--�������� ����� _STUDENTS_/_RESULTS_
ALTER TABLE results
ADD CONSTRAINT fk_student
FOREIGN KEY (student_id)
REFERENCES students (id_student)
ON DELETE CASCADE;

--�������� ����� _FIRST_ANSWERS_/_QUESTIONS_
ALTER TABLE questions
ADD CONSTRAINT fk_first_answer
FOREIGN KEY (first_answer_id)
REFERENCES first_answers (id_first_answer)
ON DELETE CASCADE;

--�������� ����� _SECOND_ANSWERS_/_QUESTIONS_
ALTER TABLE questions
ADD CONSTRAINT fk_second_answer
FOREIGN KEY (second_answer_id)
REFERENCES second_answers (id_second_answer)
ON DELETE CASCADE;

--�������� ����� _THIRD_ANSWERS_/_QUESTIONS_
ALTER TABLE questions
ADD CONSTRAINT fk_third_answer
FOREIGN KEY (third_answer_id)
REFERENCES third_answers (id_third_answer)
ON DELETE CASCADE;

---------------------------------------------------------------------

--���������� ������ � _QUESTIONS_
INSERT INTO questions (question_text, first_answer_id, second_answer_id, third_answer_id, right_answer) VALUES
('��� ������ ����������� ���������� � �� ������������:', 1, 1, 1, '����� �������'),
('������� � �������������� ����������� � ���� ������������� ����� ����������:', 2, 2, 2, '���������'),
('��� ����� ������������ ������������ �������?', 3, 3, 3, '����������� �������� ��������, � ����� ���������� �� ���������'),
('����� �� ������������� �������� ����������� ����������� ������?', 4, 4, 4, '*.gif, *.jpg'),
('����� ��� ������������ ����������� �� ������ ������������ ��� ������������� �������� ����������?', 5, 5, 5, '�������� �����������'),
('����������� ���������� - ���', 6, 6, 6, '����������� �������� ������� ��������� ����������'),
('���������� ������������ ���������� ������ ��� ��������:', 7, 7, 7, '�������� ��������� �������� �� � ������������ ��� �����'),
('������� - ���', 8, 8, 8, '���������, ����������� ���������� ������ �����������'),
('����������� ������������ ������� �������� ������ ��', 9, 9, 9, '�������� �� ������������ ����'),
('���������� ����� ���������� � ����� ������ ����������:', 10, 10, 10, '������')

--���������� ������ � _FIRST_ANSWERS_
INSERT INTO first_answers (first_answer_text) VALUES
('����'),
('�����������'),
('����� ������ ����������� ��������'),
('*.doc, *.txt'),
('�������� �����������'),
('����������� �������� ������� ��������� ����������'),
('����� ������ ����������'),
('���������� ����������� �������� ����������'),
('���������� ����������'),
('������')

--���������� ������ � _SECOND_ANSWERS_
INSERT INTO second_answers (second_answer_text) VALUES
('����������'),
('���������'),
('������ Web-������'),
('*.wav, *.mp3'),
('��������� �����������'),
('�������� ��������� ��� �����-������ ����������'),
('��������� ������������ ��������'),
('���������, ����������� ���������� ������ �����������'),
('�������� �� ������������ ����'),
('�������')

--���������� ������ � _THIRD_ANSWERS_
INSERT INTO third_answers (third_answer_text) VALUES
('����� �������'),
('���������'),
('����������� �������� ��������, � ����� ���������� �� ���������'),
('*.gif, *.jpg'),
('����������� �����������'),
('�������� �� ��� ������ ����������'),
('�������� ��������� �������� �� � ������������ ��� �����'),
('���������� ������ ����������'),
('������������ �����������'),
('�������')

---------------------------------------------------------------------

--�������� ������������� _ALL_RESULT_
CREATE VIEW all_result AS
SELECT students.student_name AS name_,
       students.student_surname AS surname_,
	   students.student_group AS group_,
	   results.student_result AS result_
FROM results INNER JOIN students ON results.student_id = students.id_student

--SELECT * FROM all_result;