// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction.
/// </summary>
[IsoId("_3RcX4Xu2EeS2Z_kGi7H1VQ")]
[DisplayName("Card Transaction Environment")]
public partial record CardTransactionEnvironment4
{
    #nullable enable
    
    /// <summary>
    /// Acquirer identification of the card transaction.
    /// </summary>
    [IsoId("_3dz_8Xu2EeS2Z_kGi7H1VQ")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text AcquirerIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the interconnected card scheme from which the request is coming.
    /// </summary>
    [IsoId("_dvwpIIPUEeSvn4rZUbUwhw")]
    [DisplayName("Card Scheme Identification")]
    [IsoXmlTag("CardSchmeId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CardSchemeIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the card acceptor performing the transaction.
    /// </summary>
    [IsoId("_3dz_9Xu2EeS2Z_kGi7H1VQ")]
    [DisplayName("Acceptor Identification")]
    [IsoXmlTag("AccptrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AcceptorIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the card terminal performing the transaction.
    /// </summary>
    [IsoId("_3dz_93u2EeS2Z_kGi7H1VQ")]
    [DisplayName("Terminal Identification")]
    [IsoXmlTag("TermnlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TerminalIdentification { get; init; } 
    
    /// <summary>
    /// Card performing the transaction.
    /// </summary>
    [IsoId("_3dz_-Xu2EeS2Z_kGi7H1VQ")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard15 Card { get; init; } 
    
    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_3dz_-3u2EeS2Z_kGi7H1VQ")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public CardPaymentToken2? PaymentToken { get; init; } 
    
    
    #nullable disable
    
}
