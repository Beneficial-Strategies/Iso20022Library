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
[IsoId("_fvs60Uk-EeK8UrXTVVBVxw")]
[DisplayName("Account Balance Extension SD")]
public partial record AccountBalanceExtensionSD2
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_gHOC8Uk-EeK8UrXTVVBVxw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Position that is concerned in transaction.
    /// </summary>
    [IsoId("_gHOC9Uk-EeK8UrXTVVBVxw")]
    [DisplayName("Transaction Position")]
    [IsoXmlTag("TxPos")]
    public AdjustedBalanceTypeSD2Choice_? TransactionPosition { get; init; } 
    
    /// <summary>
    /// Effective date of the transaction.
    /// </summary>
    [IsoId("_gHOC_0k-EeK8UrXTVVBVxw")]
    [DisplayName("As Of Date")]
    [IsoXmlTag("AsOfDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? AsOfDate { get; init; } 
    
    /// <summary>
    /// Transaction contra participant identification for stock loans, repurchase agreements (REPOs).
    /// </summary>
    [IsoId("_gHODE0k-EeK8UrXTVVBVxw")]
    [DisplayName("Contra Participant Number")]
    [IsoXmlTag("ContraPtcptNb")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    
    
    #nullable disable
    
}
