// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatusChoice
{
    /// <summary>
    /// Identifies a duplicated case. When present, the case identified in the message must be closed. The case identified as duplicated (in this component) will be pursued.
    /// </summary>
    [IsoId("_UuYYttp-Ed-ak6NoX_4Aeg_-1595640510")]
    [DisplayName("Duplicate Of")]
    public partial record DuplicateOf : InvestigationStatusChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique id assigned by the case creator.
        /// </summary>
        [IsoId("_SpAno9p-Ed-ak6NoX_4Aeg_136183942")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; } 
        
        /// <summary>
        /// Party that created the case.
        /// </summary>
        [IsoId("_SpAnpNp-Ed-ak6NoX_4Aeg_136184310")]
        [DisplayName("Creator")]
        [IsoXmlTag("Cretr")]
        [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
        public required IsoAnyBICIdentifier Creator { get; init; } 
        
        /// <summary>
        /// Set to yes if the case was closed and needs to be re-opened.
        /// </summary>
        [IsoId("_SpAnpdp-Ed-ak6NoX_4Aeg_-1913695135")]
        [DisplayName("Reopen Case Indication")]
        [IsoXmlTag("ReopCaseIndctn")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? ReopenCaseIndication { get; init; } 
        
        
        #nullable disable
        
    }
}
