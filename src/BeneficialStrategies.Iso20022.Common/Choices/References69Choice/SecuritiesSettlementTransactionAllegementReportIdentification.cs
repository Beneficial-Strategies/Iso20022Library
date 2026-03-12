// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.References69Choice
{
    /// <summary>
    /// Unambiguous identification of the report to be cancelled.
    /// </summary>
    [IsoId("_z_ogRQzXEeuUZuaHWzkTew")]
    [DisplayName("Securities Settlement Transaction Allegement Report Identification")]
    public partial record SecuritiesSettlementTransactionAllegementReportIdentification : References69Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("SctiesSttlmTxAllgmtRptId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
