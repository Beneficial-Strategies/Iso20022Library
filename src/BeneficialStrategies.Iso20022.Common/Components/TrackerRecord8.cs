// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tracker Record8.
/// </summary>
[IsoId("_P1Avw0N8Ee-QZYT2pcGFZw")]
[DisplayName("Tracker Record8")]
public partial record TrackerRecord8
{
    #nullable enable

    /// <summary>
    /// Charge Bearer.
    /// </summary>
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; } 

    /// <summary>
    /// Charges Amount.
    /// </summary>
    [DisplayName("Charges Amount")]
    [IsoXmlTag("ChrgsAmt")]
    public ActiveCurrencyAndAmount? ChargesAmount { get; init; } 

    /// <summary>
    /// Exchange Rate Data.
    /// </summary>
    [DisplayName("Exchange Rate Data")]
    [IsoXmlTag("XchgRateData")]
    public CurrencyExchange13? ExchangeRateData { get; init; } 

    /// <summary>
    /// Interbank Settlement Amount.
    /// </summary>
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? InterbankSettlementAmount { get; init; } 

    /// <summary>
    /// Party Or Agent Identification.
    /// </summary>
    [DisplayName("Party Or Agent Identification")]
    [IsoXmlTag("PtyOrAgtId")]
    public TrackerPartyIdentification2? PartyOrAgentIdentification { get; init; } 

    /// <summary>
    /// Processing Date Time.
    /// </summary>
    [DisplayName("Processing Date Time")]
    [IsoXmlTag("PrcgDtTm")]
    public IsoISODateTime? ProcessingDateTime { get; init; } 

    
    #nullable disable
    
}
