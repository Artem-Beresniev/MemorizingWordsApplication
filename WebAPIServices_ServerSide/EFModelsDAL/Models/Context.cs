
namespace EFModelsDAL.Models
{

    /// <summary>
    /// Context in which a word is being learnt.
    /// Students may memorize better a word if it is mentioned within a context:
    /// it could be a sentance, a paragraph, a unit etc.
    /// </summary>
    public class Context
    {
        public int Id { get; set; }

        /// <summary>
        /// Specifies starting point (pointer) of the occurance of the word within the unit.
        /// This value shall meet the following requirements:
        /// 1. Be more than or equal to zero.
        /// 2. Be less than <see cref="EFModelsDAL.Models.Unit.Text.Length"/> 
        ///    (number of chars of text in the unit which is referenced by the current context).
        /// </summary>
        public int? PointerStart { get; set; }

        /// <summary>
        /// Specifies end pointer of the occurance of the word within the unit.
        /// </summary>
        public int? PointerEnd { get; set; }

        public int UnitId { get; set; }

        public Unit Unit { get; set; }

        public int WordId { get; set; }

        public Word Word { get; set; }
    }
}
