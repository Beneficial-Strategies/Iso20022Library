// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// List of elements which provide the parameters of an option trade.
/// </summary>
[IsoId("_TLSOQNp-Ed-ak6NoX_4Aeg_-1226899977")]
[DisplayName("Option")]
public partial record Option3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the call and the put amount of the underlying foreign exchange trade.
    /// </summary>
    [IsoId("_TLSOQdp-Ed-ak6NoX_4Aeg_-1226899590")]
    [DisplayName("Option Amounts")]
    [IsoXmlTag("OptnAmts")]
    public required AmountsAndValueDate2 OptionAmounts { get; init; } 
    
    /// <summary>
    /// Specifies the rate of exchange at which the foreign exchange option has been struck.
    /// </summary>
    [IsoId("_TLSOQtp-Ed-ak6NoX_4Aeg_-1226899555")]
    [DisplayName("Strike Price")]
    [IsoXmlTag("StrkPric")]
    public required AgreedRate1 StrikePrice { get; init; } 
    
    /// <summary>
    /// Defines how an option can be exercised.
    /// </summary>
    [IsoId("_TLSOQ9p-Ed-ak6NoX_4Aeg_-1226899975")]
    [DisplayName("Exercise Style")]
    [IsoXmlTag("ExrcStyle")]
    public required OptionStyle2Code ExerciseStyle { get; init; } 
    
    /// <summary>
    /// First date on which an american option can be exercised.
    /// </summary>
    [IsoId("_TLSORNp-Ed-ak6NoX_4Aeg_-1226899694")]
    [DisplayName("Earliest Exercise Date")]
    [IsoXmlTag("EarlstExrcDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EarliestExerciseDate { get; init; } 
    
    /// <summary>
    /// Date on which a privilege (eg, option, right, warrant.) expires. If it is an European option, the option holder can only exercise the right or let it lapse on expiry date. If it is an American option, the option holder can exercise the right up to the expiry date.
    /// </summary>
    [IsoId("_TLSORdp-Ed-ak6NoX_4Aeg_-1226899676")]
    [DisplayName("Expiry Date And Time")]
    [IsoXmlTag("XpryDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ExpiryDateAndTime { get; init; } 
    
    /// <summary>
    /// Financial center where option expires.
    /// </summary>
    [IsoId("_TLSORtp-Ed-ak6NoX_4Aeg_-1226899651")]
    [DisplayName("Expiry Location")]
    [IsoXmlTag("XpryLctn")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public required IsoMax4AlphaNumericText ExpiryLocation { get; init; } 
    
    /// <summary>
    /// Indicates whether the trade is to be settled as principal or netted off against another trade.
    /// </summary>
    [IsoId("_TLSOR9p-Ed-ak6NoX_4Aeg_-1226899634")]
    [DisplayName("Settlement Type")]
    [IsoXmlTag("SttlmTp")]
    public required SettlementType1Code SettlementType { get; init; } 
    
    /// <summary>
    /// Free format text that may contain information on the option.
    /// </summary>
    [IsoId("_TLSOSNp-Ed-ak6NoX_4Aeg_-1226899616")]
    [DisplayName("Additional Option Information")]
    [IsoXmlTag("AddtlOptnInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? AdditionalOptionInformation { get; init; } 
    
    /// <summary>
    /// Specifies the amount of the premium of a foreign exchange option trade and its settlement place.
    /// </summary>
    [IsoId("_TLb_QNp-Ed-ak6NoX_4Aeg_-1197044330")]
    [DisplayName("Premium")]
    [IsoXmlTag("Prm")]
    public required PremiumAmount2 Premium { get; init; } 
    
    
    #nullable disable
    
}
