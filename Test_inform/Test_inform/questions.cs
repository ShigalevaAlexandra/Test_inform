//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test_inform
{
    using System;
    using System.Collections.Generic;
    
    public partial class questions
    {
        public int id_question { get; set; }
        public string question_text { get; set; }
        public int first_answer_id { get; set; }
        public int second_answer_id { get; set; }
        public int third_answer_id { get; set; }
        public string right_answer { get; set; }
    
        public virtual first_answers first_answers { get; set; }
        public virtual second_answers second_answers { get; set; }
        public virtual third_answers third_answers { get; set; }
    }
}
