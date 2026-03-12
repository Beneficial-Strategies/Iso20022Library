// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.References79Choice
{
    /// <summary>
    /// Identification of the intra-position movement posting report to be cancelled.
    /// </summary>
    [IsoId("_Wkm3jUfGEey6Is2iMqV8fg")]
    [DisplayName("Intra Position Movement Posting Report Identification")]
    public partial record IntraPositionMovementPostingReportIdentification : References79Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 16 characters. It has a pattern that disables the use of characters that is not part of the character set X, that is, that is not a-z A-Z / - ? : ( ) . , ‘ + , and disable the use of slash &quot;/&quot; at the beginning and end of line and double slash &quot;//&quot; within the line.
        /// </summary>
        [IsoXmlTag("IntraPosMvmntPstngRptId")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
        [StringLength(maximumLength: 16 ,MinimumLength = 1)]
        public required IsoRestrictedFINXMax16Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
