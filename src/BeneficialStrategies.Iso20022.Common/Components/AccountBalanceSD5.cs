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
[IsoId("_oKuCA3oAEeO2o_OAyvnbZw")]
[DisplayName("Account Balance SD")]
public partial record AccountBalanceSD5
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_oKuCDHoAEeO2o_OAyvnbZw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Position that is concerned in transaction.
    /// </summary>
    [IsoId("_oKuCDnoAEeO2o_OAyvnbZw")]
    [DisplayName("Transaction Position")]
    [IsoXmlTag("TxPos")]
    public AdjustedBalanceTypeSD1Choice_? TransactionPosition { get; init; } 
    
    /// <summary>
    /// Effective date of the transaction.
    /// </summary>
    [IsoId("_oKuCEnoAEeO2o_OAyvnbZw")]
    [DisplayName("As Of Date")]
    [IsoXmlTag("AsOfDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? AsOfDate { get; init; } 
    
    /// <summary>
    /// Transaction contra participant identification for stock loans, repurchase agreements (REPOs).
    /// </summary>
    [IsoId("_oKuCCHoAEeO2o_OAyvnbZw")]
    [DisplayName("Contra Participant Number")]
    [IsoXmlTag("ContraPtcptNb")]
    [IsoSimpleType(IsoSimpleType.Max8Text)]
    [StringLength(maximumLength: 8 ,MinimumLength = 1)]
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    
    
    #nullable disable
    
}
