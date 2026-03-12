// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatus2Choice
{
    /// <summary>
    /// Indicates a duplicated case. |Usage: When present, the case identified in the message must be closed. The case identified as duplicated (in this component) will be pursued.
    /// </summary>
    [IsoId("_T-P8R9p-Ed-ak6NoX_4Aeg_523813131")]
    [DisplayName("Duplicate Of")]
    public partial record DuplicateOf : InvestigationStatus2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Uniquely identifies the case.
        /// </summary>
        [IsoId("_SpAnp9p-Ed-ak6NoX_4Aeg_-1565053102")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; } 
        
        /// <summary>
        /// Party that created the investigation case.
        /// </summary>
        [IsoId("_SpAnqNp-Ed-ak6NoX_4Aeg_-1667764151")]
        [DisplayName("Creator")]
        [IsoXmlTag("Cretr")]
        public required Party7Choice_ Creator { get; init; } 
        
        /// <summary>
        /// Indicates whether or not the case was previously closed and is now re-opened.
        /// </summary>
        [IsoId("_SpAnqdp-Ed-ak6NoX_4Aeg_-1565052762")]
        [DisplayName("Reopen Case Indication")]
        [IsoXmlTag("ReopCaseIndctn")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? ReopenCaseIndication { get; init; } 
        
        
        #nullable disable
        
    }
}
