// This file was automatically generated and may be regenerated at any
// time. To ensure any changes are retained, modify the tool with any segment/component/group/field name
// or type changes.
namespace Machete.HL7Schema.V26.Maps
{
    using V26;

    /// <summary>
    /// PPT_PCL (MessageMap) - 
    /// </summary>
    public class PPT_PCLMap :
        HL7V26LayoutMap<PPT_PCL>
    {
        public PPT_PCLMap()
        {
            Segment(x => x.MSH, 0, x => x.Required = true);
            Segment(x => x.SFT, 1);
            Segment(x => x.UAC, 2);
            Segment(x => x.MSA, 3, x => x.Required = true);
            Segment(x => x.ERR, 4);
            Segment(x => x.QAK, 5);
            Segment(x => x.QRD, 6, x => x.Required = true);
            Layout(x => x.Patient, 7, x => x.Required = true);
        }
    }
}