//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookMaster.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cover
    {
        public Cover()
        {
            this.BookCover = new HashSet<BookCover>();
        }
    
        public int Coverid { get; set; }
        public byte[] CoverFile { get; set; }
    
        public virtual ICollection<BookCover> BookCover { get; set; }
    }
}
