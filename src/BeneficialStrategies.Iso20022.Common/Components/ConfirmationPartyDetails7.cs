// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parties used for acting parties that apply either to the whole message or to individual sides.
/// </summary>
[IsoId("_h-wZ7Y-iEeaEa8S_GI1QNA")]
[DisplayName("Confirmation Party Details")]
public record ConfirmationPartyDetails7
{
    /// <summary>
    /// Unique and unambiguous identifier for an organisation that is allocated by an institution, eg, Dun &amp; Bradstreet Identification.
    /// </summary>
    [IsoId("_iNL3Y4-iEeaEa8S_GI1QNA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification117Choice_ Identification { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_iNL3cY-iEeaEa8S_GI1QNA")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification8? AlternateIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    [IsoId("_iNL3c4-iEeaEa8S_GI1QNA")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessingIdentification { get; init; }

    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    [IsoId("_iNL3e4-iEeaEa8S_GI1QNA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation5? AdditionalInformation { get; init; }

    /// <summary>
    /// Capacity of customer placing the order. Primarily used by futures exchanges to indicate the CTI code (customer type indicator) as required by the US CFTC (Commodity Futures Trading Commission).
    /// </summary>
    [IsoId("_iNL3fY-iEeaEa8S_GI1QNA")]
    [DisplayName("Investor Capacity")]
    [IsoXmlTag("InvstrCpcty")]
    public InvestorCapacity4Choice_? InvestorCapacity { get; init; }

    /// <summary>
    /// Capacity of customer placing the order. Primarily used by futures exchanges to indicate the CTI code (customer type indicator) as required by the US CFTC (Commodity Futures Trading Commission).
    /// </summary>
    [IsoId("_iNL3hY-iEeaEa8S_GI1QNA")]
    [DisplayName("Trading Party Capacity")]
    [IsoXmlTag("TradgPtyCpcty")]
    public TradingPartyCapacity4Choice_? TradingPartyCapacity { get; init; }
}
