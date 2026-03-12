// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatus4Choice
{
    /// <summary>
    /// Indicates a duplicated case. |Usage: When present, the case identified in the message must be closed. The case identified as duplicated (in this component) will be pursued.
    /// </summary>
    [IsoId("_nbwAl4mxEeeKR__nUfxjwA")]
    [DisplayName("Duplicate Of")]
    public partial record DuplicateOf : InvestigationStatus4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Uniquely identifies the case.
        /// </summary>
        [IsoId("_mvnbwbTREeeyuKckOGlwuA")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; } 
        
        /// <summary>
        /// Party that created the investigation case.
        /// </summary>
        [IsoId("_mvnbw7TREeeyuKckOGlwuA")]
        [DisplayName("Creator")]
        [IsoXmlTag("Cretr")]
        public required Party35Choice_ Creator { get; init; } 
        
        /// <summary>
        /// Indicates whether or not the case was previously closed and is now re-opened.
        /// </summary>
        [IsoId("_mvnbxbTREeeyuKckOGlwuA")]
        [DisplayName("Reopen Case Indication")]
        [IsoXmlTag("ReopCaseIndctn")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? ReopenCaseIndication { get; init; } 
        
        
        #nullable disable
        
    }
}
