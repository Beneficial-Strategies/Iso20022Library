// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.References3Choice
{
    /// <summary>
    /// Unambiguous identification of the allegement notification to be cancelled as know by the account servicer.
    /// </summary>
    [IsoId("_USz3Btp-Ed-ak6NoX_4Aeg_2080550219")]
    [DisplayName("Securities Settlement Transaction Allegement Notification Transaction Identification")]
    public partial record SecuritiesSettlementTransactionAllegementNotificationTransactionIdentification : References3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("SctiesSttlmTxAllgmtNtfctnTxId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
