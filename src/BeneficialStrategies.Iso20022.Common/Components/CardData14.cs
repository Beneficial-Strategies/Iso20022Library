// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Card Data14.
/// </summary>
[IsoId("_9nWMEX5WEe6YlIMyoxWMJA")]
[DisplayName("Card Data14")]
public partial record CardData14
{
    #nullable enable

    /// <summary>
    /// Card Sequence Number.
    /// </summary>
    [DisplayName("Card Sequence Number")]
    [IsoXmlTag("CardSeqNb")]
    public IsoMin2Max3NumericText? CardSequenceNumber { get; init; } 

    /// <summary>
    /// PAN.
    /// </summary>
    [DisplayName("PAN")]
    [IsoXmlTag("PAN")]
    public IsoMax19NumericText? PAN { get; init; } 

    /// <summary>
    /// Payment Account Reference.
    /// </summary>
    [DisplayName("Payment Account Reference")]
    [IsoXmlTag("PmtAcctRef")]
    public IsoMax35Text? PaymentAccountReference { get; init; } 

    /// <summary>
    /// Portfolio Identifier.
    /// </summary>
    [DisplayName("Portfolio Identifier")]
    [IsoXmlTag("PrtflIdr")]
    public IsoMax35Text? PortfolioIdentifier { get; init; } 

    
    #nullable disable
    
}
