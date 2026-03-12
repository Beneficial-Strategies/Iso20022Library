// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding account balance. Contains transaction details of the stock loans, repurchase agreements (REPOs) and undelivered trades (FAILs).
/// </summary>
[IsoId("_hn-gQb5YEeexmbB7KsjCwA")]
[DisplayName("Account Balance SD")]
public partial record AccountBalanceSD10
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_h5PPYb5YEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Position that is concerned in transaction.
    /// </summary>
    [IsoId("_h5PPY75YEeexmbB7KsjCwA")]
    [DisplayName("Transaction Position")]
    [IsoXmlTag("TxPos")]
    public AdjustedBalanceTypeSD4Choice_? TransactionPosition { get; init; } 
    
    /// <summary>
    /// Transaction contra participant identification for stock loans, repurchase agreements (REPOs).
    /// </summary>
    [IsoId("_h5PPa75YEeexmbB7KsjCwA")]
    [DisplayName("Contra Participant Number")]
    [IsoXmlTag("ContraPtcptNb")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    
    
    #nullable disable
    
}
