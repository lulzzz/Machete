// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// OMG_O19_PATIENT_PRIOR (GroupMap) - 
    /// </summary>
    public class OMG_O19_PATIENT_PRIORMap :
        HL7V26LayoutMap<OMG_O19_PATIENT_PRIOR>
    {
        public OMG_O19_PATIENT_PRIORMap()
        {
            Segment(x => x.PID, 0, x => x.Required = true);
            Segment(x => x.PD1, 1);
        }
    }
}