// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Description of the financial instrument.
/// </summary>
[IsoId("_Tx4UNdp-Ed-ak6NoX_4Aeg_-800922818")]
[DisplayName("Financial Instrument Attributes")]
public partial record FinancialInstrumentAttributes3
{
    #nullable enable
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_Tx4UNtp-Ed-ak6NoX_4Aeg_-800922446")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification11 SecurityIdentification { get; init; } 
    
    /// <summary>
    /// Quantity of entitled intermediate securities based on the balance of underlying securities.
    /// </summary>
    [IsoId("_Tx4UN9p-Ed-ak6NoX_4Aeg_-299452126")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? Quantity { get; init; } 
    
    /// <summary>
    /// Specifies whether terms of the event allow resale of the rights.
    /// </summary>
    [IsoId("_Tx4UONp-Ed-ak6NoX_4Aeg_-1617519156")]
    [DisplayName("Renounceable Entitlement Status Type")]
    [IsoXmlTag("RnncblEntitlmntStsTp")]
    public RenounceableEntitlementStatusTypeFormat1Choice_? RenounceableEntitlementStatusType { get; init; } 
    
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    [IsoId("_TyCFMNp-Ed-ak6NoX_4Aeg_-831602303")]
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType3Choice_? FractionDisposition { get; init; } 
    
    /// <summary>
    /// Quantity of intermediate securities awarded for a given quantity of underlying security.
    /// </summary>
    [IsoId("_TyCFMdp-Ed-ak6NoX_4Aeg_-2130665569")]
    [DisplayName("Intermediate Securities To Underlying Ratio")]
    [IsoXmlTag("IntrmdtSctiesToUndrlygRatio")]
    public QuantityToQuantityRatio1? IntermediateSecuritiesToUnderlyingRatio { get; init; } 
    
    /// <summary>
    /// Last reported/known price of a financial instrument in a market.
    /// </summary>
    [IsoId("_TyCFMtp-Ed-ak6NoX_4Aeg_564112779")]
    [DisplayName("Market Price")]
    [IsoXmlTag("MktPric")]
    public AmountPrice2? MarketPrice { get; init; } 
    
    /// <summary>
    /// Date on which an order expires or at which a privilege or offer terminates.
    /// </summary>
    [IsoId("_TyCFM9p-Ed-ak6NoX_4Aeg_-1352785741")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public required DateFormat5Choice_ ExpiryDate { get; init; } 
    
    /// <summary>
    /// Date of the posting (credit or debit) to the account.
    /// </summary>
    [IsoId("_TyCFNNp-Ed-ak6NoX_4Aeg_-1338012503")]
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    public required DateFormat5Choice_ PostingDate { get; init; } 
    
    /// <summary>
    /// Period during which intermediate or outturn securities are tradable in a secondary market.
    /// </summary>
    [IsoId("_TyCFNdp-Ed-ak6NoX_4Aeg_-1071910140")]
    [DisplayName("Trading Period")]
    [IsoXmlTag("TradgPrd")]
    public Period3? TradingPeriod { get; init; } 
    
    /// <summary>
    /// Balance of uninstructed position.
    /// </summary>
    [IsoId("_TyCFNtp-Ed-ak6NoX_4Aeg_172257252")]
    [DisplayName("Uninstructed Balance")]
    [IsoXmlTag("UinstdBal")]
    public BalanceFormat1Choice_? UninstructedBalance { get; init; } 
    
    /// <summary>
    /// Balance of instructed position.
    /// </summary>
    [IsoId("_TyCFN9p-Ed-ak6NoX_4Aeg_-824815101")]
    [DisplayName("Instructed Balance")]
    [IsoXmlTag("InstdBal")]
    public BalanceFormat1Choice_? InstructedBalance { get; init; } 
    
    
    #nullable disable
    
}
