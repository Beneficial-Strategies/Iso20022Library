// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding underlying security details.
/// </summary>
[IsoId("_Z4b8UV2qEeOb__BffbPEig")]
[DisplayName("Financial Instrument Attributes SD")]
public record FinancialInstrumentAttributesSD8
{
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_aRumEV2qEeOb__BffbPEig")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; }

    /// <summary>
    /// Country in which the security was issued.
    /// </summary>
    [IsoId("_aRumE12qEeOb__BffbPEig")]
    [DisplayName("Country Of Listing")]
    [IsoXmlTag("CtryOfListg")]
    public CountryCode? CountryOfListing { get; init; }

    /// <summary>
    /// Country of source income for the security.
    /// </summary>
    [IsoId("_aRumG12qEeOb__BffbPEig")]
    [DisplayName("Income Source Country")]
    [IsoXmlTag("IncmSrcCtry")]
    public CountryCode? IncomeSourceCountry { get; init; }

    /// <summary>
    /// Classification of instruments into asset classes at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_aRumI12qEeOb__BffbPEig")]
    [DisplayName("DTC Asset Class")]
    [IsoXmlTag("DTCAsstClss")]
    public AssetClass1Code? DTCAssetClass { get; init; }

    /// <summary>
    /// Further classification of instruments into (issue) asset types at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_aRumK12qEeOb__BffbPEig")]
    [DisplayName("DTC Asset Type")]
    [IsoXmlTag("DTCAsstTp")]
    public DTCAssetType1Code? DTCAssetType { get; init; }

    /// <summary>
    /// Indicates whether the security is eligible for holding at DTC.
    /// </summary>
    [IsoId("_aRumM12qEeOb__BffbPEig")]
    [DisplayName("Security Eligibility Indicator")]
    [IsoXmlTag("SctyElgbltyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SecurityEligibilityIndicator { get; init; }

    /// <summary>
    /// Ticket symbol for the event security (underlying security).
    /// </summary>
    [IsoId("_aRumO12qEeOb__BffbPEig")]
    [DisplayName("Ticker Symbol")]
    [IsoXmlTag("TckrSymb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TickerSymbol { get; init; }

    /// <summary>
    /// Security whose characteristics mirror the event security for purposes of FCP eligibility and tax relief. Certain derivative securities like HOLDR may have certain events where the source of payments are from an underlying security.
    /// </summary>
    [IsoId("_aRumQ12qEeOb__BffbPEig")]
    [DisplayName("Linked Security")]
    [IsoXmlTag("LkdScty")]
    public SecurityIdentification15? LinkedSecurity { get; init; }

    /// <summary>
    /// Represents the &apos;original&apos; security identifier of the event. It is used in the scenarios like &quot;partial call&quot; where there are 2 events. The first event distributes into the Contra CUSIP, a temporary security; and on the second event that temporary security becomes the underlying security of the event. This element is used in the second event to point to the original CUSIP.
    /// </summary>
    [IsoId("_odHGsF2qEeOb__BffbPEig")]
    [DisplayName("Originating Security Identification")]
    [IsoXmlTag("OrgtgSctyId")]
    public OtherIdentification2? OriginatingSecurityIdentification { get; init; }
}
