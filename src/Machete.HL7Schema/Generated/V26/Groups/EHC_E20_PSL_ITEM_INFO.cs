// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26
{
    using HL7;

    /// <summary>
    /// EHC_E20_PSL_ITEM_INFO (Group) - 
    /// </summary>
    public interface EHC_E20_PSL_ITEM_INFO :
        HL7V26Layout
    {
        /// <summary>
        /// PSL
        /// </summary>
        Segment<PSL> PSL { get; }

        /// <summary>
        /// NTE
        /// </summary>
        SegmentList<NTE> NTE { get; }

        /// <summary>
        /// ADJ
        /// </summary>
        SegmentList<ADJ> ADJ { get; }

        /// <summary>
        /// LOC
        /// </summary>
        SegmentList<LOC> LOC { get; }

        /// <summary>
        /// ROL
        /// </summary>
        SegmentList<ROL> ROL { get; }
    }
}