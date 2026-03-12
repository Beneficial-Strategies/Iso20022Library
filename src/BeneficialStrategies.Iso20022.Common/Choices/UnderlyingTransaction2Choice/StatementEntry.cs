// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UnderlyingTransaction2Choice
{
    /// <summary>
    /// Reference details on the underlying statement cash entry.
    /// </summary>
    [IsoId("_P3XHQp9XEeGBX4a4yy-WHg_1277676598")]
    [DisplayName("Statement Entry")]
    public partial record StatementEntry : UnderlyingTransaction2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Set of elements used to provide information on the original message.
        /// </summary>
        [IsoId("_T9Dpcdp-Ed-ak6NoX_4Aeg_1694597164")]
        [DisplayName("Original Group Information")]
        [IsoXmlTag("OrgnlGrpInf")]
        public OriginalGroupInformation3? OriginalGroupInformation { get; init; } 
        
        /// <summary>
        /// Unique identification, as assigned by the account servicer, to unambiguously identify the original statement.
        /// </summary>
        [IsoId("_T9Dpctp-Ed-ak6NoX_4Aeg_1694596697")]
        [DisplayName("Original Statement Identification")]
        [IsoXmlTag("OrgnlStmtId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? OriginalStatementIdentification { get; init; } 
        
        /// <summary>
        /// Original unique identification, as assigned by the account servicer, to unambiguously identify the original entry.
        /// </summary>
        [IsoId("_T9Dpc9p-Ed-ak6NoX_4Aeg_1694596718")]
        [DisplayName("Original Entry Identification")]
        [IsoXmlTag("OrgnlNtryId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? OriginalEntryIdentification { get; init; } 
        
        
        #nullable disable
        
    }
}
