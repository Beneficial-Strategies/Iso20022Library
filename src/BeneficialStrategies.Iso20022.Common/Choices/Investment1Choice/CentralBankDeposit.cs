// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Investment1Choice
{
    /// <summary>
    /// Indicates that the bank deposit is placed at a central bank.
    /// </summary>
    [IsoId("_UYA14LJVEeaYqc4G3TTwhA")]
    [DisplayName("Central Bank Deposit")]
    public partial record CentralBankDeposit : Investment1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Date on which the deposit matures.
        /// </summary>
        [IsoId("_H_pLALJVEeaYqc4G3TTwhA")]
        [DisplayName("Maturity Date")]
        [IsoXmlTag("MtrtyDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate MaturityDate { get; init; } 
        
        /// <summary>
        /// Specifies the value of the deposit.
        /// </summary>
        [IsoId("_LYG7oLJVEeaYqc4G3TTwhA")]
        [DisplayName("Value")]
        [IsoXmlTag("Val")]
        public required ActiveCurrencyAndAmount Value { get; init; } 
        
        /// <summary>
        /// Identifies the legal entity that takes the deposit.
        /// </summary>
        [IsoId("_N0LVcLJVEeaYqc4G3TTwhA")]
        [DisplayName("Counterparty Identification")]
        [IsoXmlTag("CtrPtyId")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public required IsoLEIIdentifier CounterpartyIdentification { get; init; } 
        
        
        #nullable disable
        
    }
}
