// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference of the message previously received and for which the delivery status is notified.
/// </summary>
[IsoId("_rrrBUQ2zEeWH49U6bkyMaA")]
[DisplayName("Related Reference")]
public partial record RelatedReference1
{
    #nullable enable
    
    /// <summary>
    /// Unique transaction identifier assigned by the local application.
    /// </summary>
    [IsoId("_JFLwQRJaEeWg-NN-FmovgQ")]
    [DisplayName("Transaction Unique Identifier")]
    [IsoXmlTag("TxUnqIdr")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? TransactionUniqueIdentifier { get; init; } 
    
    /// <summary>
    /// Message reference assigned by the original message sender.
    /// </summary>
    [IsoId("_F5zZYRJaEeWg-NN-FmovgQ")]
    [DisplayName("Message Reference")]
    [IsoXmlTag("MsgRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MessageReference { get; init; } 
    
    
    #nullable disable
    
}
