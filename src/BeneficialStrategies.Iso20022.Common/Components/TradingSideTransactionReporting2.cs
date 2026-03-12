// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Regulatory transaction reporting information from the Trading Side party.
/// </summary>
[IsoId("_Cb9qwwN1Ee2-vqzwMUAewg")]
[DisplayName("Trading Side Transaction Reporting")]
public partial record TradingSideTransactionReporting2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the supervisory party to which the trade needs to be reported.
    /// </summary>
    [IsoId("_ChWhAQN1Ee2-vqzwMUAewg")]
    [DisplayName("Reporting Jurisdiction")]
    [IsoXmlTag("RptgJursdctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ReportingJurisdiction { get; init; } 
    
    /// <summary>
    /// Identifies the party that is responsible for reporting the trade to the trade repository.
    /// </summary>
    [IsoId("_ChWhAwN1Ee2-vqzwMUAewg")]
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public PartyIdentification242Choice_? ReportingParty { get; init; } 
    
    /// <summary>
    /// Specifies the unique transaction identifier (UTI) to be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction over its life. This identifier can also be known as the Unique Swap Identifier (USI). This is the UTI from the Trading Side party.
    /// </summary>
    [IsoId("_ChWhBQN1Ee2-vqzwMUAewg")]
    [DisplayName("Trading Side Unique Transaction Identifier")]
    [IsoXmlTag("TradgSdUnqTxIdr")]
    public UniqueTransactionIdentifier2? TradingSideUniqueTransactionIdentifier { get; init; } 
    
    
    #nullable disable
    
}
