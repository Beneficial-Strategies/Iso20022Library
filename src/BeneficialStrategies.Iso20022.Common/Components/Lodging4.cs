// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Lodging4.
/// </summary>
[IsoId("_xbSzYXTpEe6h-4AZRg9sVg")]
[DisplayName("Lodging4")]
public record Lodging4
{
    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Arrival.
    /// </summary>
    [DisplayName("Arrival")]
    [IsoXmlTag("Arrvl")]
    public DepartureOrArrival2? Arrival { get; init; }

    /// <summary>
    /// Authorised Amount.
    /// </summary>
    [DisplayName("Authorised Amount")]
    [IsoXmlTag("AuthrsdAmt")]
    public ValueList<AuthorisedAmount2> AuthorisedAmount { get; init; } = [];

    /// <summary>
    /// Customer Address.
    /// </summary>
    [DisplayName("Customer Address")]
    [IsoXmlTag("CstmrAdr")]
    public Address2? CustomerAddress { get; init; }

    /// <summary>
    /// Customer Age.
    /// </summary>
    [DisplayName("Customer Age")]
    [IsoXmlTag("CstmrAge")]
    public IsoMax2NumericText? CustomerAge { get; init; }

    /// <summary>
    /// Customer Contact.
    /// </summary>
    [DisplayName("Customer Contact")]
    [IsoXmlTag("CstmrCtct")]
    public ContactPersonal1? CustomerContact { get; init; }

    /// <summary>
    /// Customer File Reference Number.
    /// </summary>
    [DisplayName("Customer File Reference Number")]
    [IsoXmlTag("CstmrFileRefNb")]
    public IsoMax70Text? CustomerFileReferenceNumber { get; init; }

    /// <summary>
    /// Customer Identification.
    /// </summary>
    [DisplayName("Customer Identification")]
    [IsoXmlTag("CstmrId")]
    public Credentials3? CustomerIdentification { get; init; }

    /// <summary>
    /// Customer Name.
    /// </summary>
    [DisplayName("Customer Name")]
    [IsoXmlTag("CstmrNm")]
    public IsoMax70Text? CustomerName { get; init; }

    /// <summary>
    /// Departure.
    /// </summary>
    [DisplayName("Departure")]
    [IsoXmlTag("Dprture")]
    public DepartureOrArrival1? Departure { get; init; }

    /// <summary>
    /// Duration.
    /// </summary>
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public IsoMax4NumericText? Duration { get; init; }

    /// <summary>
    /// Folio Number.
    /// </summary>
    [DisplayName("Folio Number")]
    [IsoXmlTag("FolioNb")]
    public IsoMax35Text? FolioNumber { get; init; }

    /// <summary>
    /// Insurance.
    /// </summary>
    [DisplayName("Insurance")]
    [IsoXmlTag("Insrnc")]
    public IsoTrueFalseIndicator? Insurance { get; init; }

    /// <summary>
    /// Insurance Amount.
    /// </summary>
    [DisplayName("Insurance Amount")]
    [IsoXmlTag("InsrncAmt")]
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; }

    /// <summary>
    /// Line Item.
    /// </summary>
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public ValueList<LodgingLineItem3> LineItem { get; init; } = [];

    /// <summary>
    /// Loyalty Programme.
    /// </summary>
    [DisplayName("Loyalty Programme")]
    [IsoXmlTag("LltyPrgrmm")]
    public ValueList<LoyaltyProgramme4> LoyaltyProgramme { get; init; } = [];

    /// <summary>
    /// No Show.
    /// </summary>
    [DisplayName("No Show")]
    [IsoXmlTag("NoShow")]
    public IsoTrueFalseIndicator? NoShow { get; init; }

    /// <summary>
    /// Number Of Rooms.
    /// </summary>
    [DisplayName("Number Of Rooms")]
    [IsoXmlTag("NbOfRooms")]
    public IsoMax4NumericText? NumberOfRooms { get; init; }

    /// <summary>
    /// Prestigious Property.
    /// </summary>
    [DisplayName("Prestigious Property")]
    [IsoXmlTag("PrstgsPrprty")]
    public IsoMax35Text? PrestigiousProperty { get; init; }

    /// <summary>
    /// Property Assigner.
    /// </summary>
    [DisplayName("Property Assigner")]
    [IsoXmlTag("PrprtyAssgnr")]
    public CompanyAssigner2Code? PropertyAssigner { get; init; }

    /// <summary>
    /// Property Contact.
    /// </summary>
    [DisplayName("Property Contact")]
    [IsoXmlTag("PrprtyCtct")]
    public ContactBusiness1? PropertyContact { get; init; }

    /// <summary>
    /// Property Country.
    /// </summary>
    [DisplayName("Property Country")]
    [IsoXmlTag("PrprtyCtry")]
    public ISOMax3ACountryCode? PropertyCountry { get; init; }

    /// <summary>
    /// Property Fire Safety Act.
    /// </summary>
    [DisplayName("Property Fire Safety Act")]
    [IsoXmlTag("PrprtyFireSftyAct")]
    public IsoTrueFalseIndicator? PropertyFireSafetyAct { get; init; }

    /// <summary>
    /// Property Identification.
    /// </summary>
    [DisplayName("Property Identification")]
    [IsoXmlTag("PrprtyId")]
    public PartyIdentification285? PropertyIdentification { get; init; }

    /// <summary>
    /// Property Location.
    /// </summary>
    [DisplayName("Property Location")]
    [IsoXmlTag("PrprtyLctn")]
    public Location6? PropertyLocation { get; init; }

    /// <summary>
    /// Property Name.
    /// </summary>
    [DisplayName("Property Name")]
    [IsoXmlTag("PrprtyNm")]
    public IsoMax35Text? PropertyName { get; init; }

    /// <summary>
    /// Property Other Type.
    /// </summary>
    [DisplayName("Property Other Type")]
    [IsoXmlTag("PrprtyOthrTp")]
    public IsoMax35Text? PropertyOtherType { get; init; }

    /// <summary>
    /// Property Type.
    /// </summary>
    [DisplayName("Property Type")]
    [IsoXmlTag("PrprtyTp")]
    public LodgingActivity1Code? PropertyType { get; init; }

    /// <summary>
    /// Room.
    /// </summary>
    [DisplayName("Room")]
    [IsoXmlTag("Room")]
    public ValueList<LodgingRoom2> Room { get; init; } = [];

    /// <summary>
    /// Summary Commodity Identification.
    /// </summary>
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Total Amount.
    /// </summary>
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Total Tax.
    /// </summary>
    [DisplayName("Total Tax")]
    [IsoXmlTag("TtlTax")]
    public ValueList<Tax41> TotalTax { get; init; } = [];
}
