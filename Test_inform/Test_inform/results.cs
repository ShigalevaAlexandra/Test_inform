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
    
    public partial class results
    {
        public int id_result { get; set; }
        public int student_id { get; set; }
        public int student_result { get; set; }
    
        public virtual students students { get; set; }
    }
}
