// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransactionIdentification1Choice
{
    /// <summary>
    /// Provides identification of the securities financial transaction.
    /// </summary>
    [IsoId("_lv0vQK7LEemZxoEFHjN-AQ")]
    [DisplayName("Transaction")]
    public partial record Transaction : TransactionIdentification1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique code identifying the reporting counterparty.
        /// </summary>
        [IsoId("_CYn3gaxiEem81-uIvTF5rQ")]
        [DisplayName("Reporting Counterparty")]
        [IsoXmlTag("RptgCtrPty")]
        public required OrganisationIdentification9Choice_ ReportingCounterparty { get; init; } 
        
        /// <summary>
        /// Unique code identifying the entity with which the reporting counterparty concluded the transaction.
        /// </summary>
        [IsoId("_CYn3g6xiEem81-uIvTF5rQ")]
        [DisplayName("Other Counterparty")]
        [IsoXmlTag("OthrCtrPty")]
        public required OrganisationIdentification9Choice_ OtherCounterparty { get; init; } 
        
        /// <summary>
        /// Unique trade Identifier (UTI) as agreed with the counterparty.
        /// </summary>
        [IsoId("_CYn3haxiEem81-uIvTF5rQ")]
        [DisplayName("Unique Trade Identifier")]
        [IsoXmlTag("UnqTradIdr")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        public IsoMax52Text? UniqueTradeIdentifier { get; init; } 
        
        /// <summary>
        /// Details related to the master agreement.
        /// </summary>
        [IsoId("_CYn3h6xiEem81-uIvTF5rQ")]
        [DisplayName("Master Agreement")]
        [IsoXmlTag("MstrAgrmt")]
        public MasterAgreement6? MasterAgreement { get; init; } 
        
        /// <summary>
        /// Identification of the agent lender involved in the securities lending transaction.
        /// </summary>
        [IsoId("_FbGxEKxiEem81-uIvTF5rQ")]
        [DisplayName("Agent Lender")]
        [IsoXmlTag("AgtLndr")]
        public OrganisationIdentification9Choice_? AgentLender { get; init; } 
        
        /// <summary>
        /// Identification of the third party that administers the transaction.
        /// </summary>
        [IsoId("_GhJMEKxiEem81-uIvTF5rQ")]
        [DisplayName("Triparty Agent")]
        [IsoXmlTag("TrptyAgt")]
        public OrganisationIdentification9Choice_? TripartyAgent { get; init; } 
        
        
        #nullable disable
        
    }
}
