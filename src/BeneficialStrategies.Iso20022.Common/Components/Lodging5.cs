// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Lodging provides summary information about lodging accommodations and related expenses for the cardholder.
/// </summary>
[IsoId("_UdImAUhsEfCMZJtj4J7UGQ")]
[DisplayName("Lodging5")]
public record Lodging5
{
    /// <summary>
    /// Contains the lodging company's invoice or billing ID reference number, referred to as a folio number.
    /// </summary>
    [IsoId("_UfdhQUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Folio Number")]
    [IsoXmlTag("FolioNb")]
    public IsoMax35Text? FolioNumber { get; init; }

    /// <summary>
    /// Type of accommodations. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_UfdhQ0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Property Type")]
    [IsoXmlTag("PrprtyTp")]
    public LodgingActivity2Code? PropertyType { get; init; }

    /// <summary>
    /// Identifier that describes the lodging establishment as a prestigious property.
    /// </summary>
    [IsoId("_UfdhR0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Prestigious Property")]
    [IsoXmlTag("PrstgsPrprty")]
    public IsoMax35Text? PrestigiousProperty { get; init; }

    /// <summary>
    /// Name of the property.
    /// </summary>
    [IsoId("_UfdhSUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Property Name")]
    [IsoXmlTag("PrprtyNm")]
    public IsoMax35Text? PropertyName { get; init; }

    /// <summary>
    /// Identification of the property.
    /// </summary>
    [IsoId("_UqF1N0hyEfCMZJtj4J7UGQ")]
    [DisplayName("Property Identification")]
    [IsoXmlTag("PrprtyId")]
    public IsoMax35Text? PropertyIdentification { get; init; }

    /// <summary>
    /// Business name of the property.
    /// </summary>
    [IsoId("_UqF1OEhyEfCMZJtj4J7UGQ")]
    [DisplayName("Property Business Name")]
    [IsoXmlTag("PrprtyBizNm")]
    public IsoMax35Text? PropertyBusinessName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the property.
    /// </summary>
    [IsoId("_UqF1OUhyEfCMZJtj4J7UGQ")]
    [DisplayName("Property Legal Corporate Name")]
    [IsoXmlTag("PrprtyLglCorpNm")]
    public IsoMax99Text? PropertyLegalCorporateName { get; init; }

    /// <summary>
    /// Address of the property.
    /// </summary>
    [IsoId("_UqF1O0hyEfCMZJtj4J7UGQ")]
    [DisplayName("Property Address")]
    [IsoXmlTag("PrprtyAdr")]
    public Address4? PropertyAddress { get; init; }

    /// <summary>
    /// Contains the property location code.
    /// </summary>
    [IsoId("_B-FaUUh4EfCMZJtj4J7UGQ")]
    [DisplayName("Property Location Code")]
    [IsoXmlTag("PrprtyLctnCd")]
    public IsoMax35Text? PropertyLocationCode { get; init; }

    /// <summary>
    /// Local time zone of the property.
    /// </summary>
    [IsoId("_h1Wt4kh4EfCMZJtj4J7UGQ")]
    [DisplayName("Property Local Time Zone")]
    [IsoXmlTag("PrprtyLclTmZone")]
    public IsoMax70Text? PropertyLocalTimeZone { get; init; }

    /// <summary>
    /// Contains local language equivalent(s) of property data.
    /// </summary>
    [IsoId("_UqF1OkhyEfCMZJtj4J7UGQ")]
    [DisplayName("Property Local Data")]
    [IsoXmlTag("PrprtyLclData")]
    public ValueList<LocalData20> PropertyLocalData { get; init; } = [];

    /// <summary>
    /// Local currency of the property.
    /// </summary>
    [IsoId("_h1Wt40h4EfCMZJtj4J7UGQ")]
    [DisplayName("Property Local Currency")]
    [IsoXmlTag("PrprtyLclCcy")]
    public ISO3NumericCurrencyCode? PropertyLocalCurrency { get; init; }

    /// <summary>
    /// Contact details at property.
    /// </summary>
    [IsoId("_UfdhUUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Property Contact")]
    [IsoXmlTag("PrprtyCtct")]
    public ContactBusiness1? PropertyContact { get; init; }

    /// <summary>
    /// Indicates whether or not the lodging facility complies with the US Hotel and Motel Fire Safety Act of 1990 or similar legislation.
    /// </summary>
    [IsoId("_UfdhVUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Property Fire Safety Act")]
    [IsoXmlTag("PrprtyFireSftyAct")]
    public IsoTrueFalseIndicator? PropertyFireSafetyAct { get; init; }

    /// <summary>
    /// Name of the customer.
    /// </summary>
    [IsoId("_UfdhV0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public ValueList<Customer10> Customer { get; init; } = [];

    /// <summary>
    /// Number of rooms within the reservation.
    /// </summary>
    [IsoId("_UfdhY0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Number Of Rooms")]
    [IsoXmlTag("NbOfRooms")]
    public IsoMax4NumericText? NumberOfRooms { get; init; }

    /// <summary>
    /// Contains the room details.
    /// </summary>
    [IsoId("_UfdhZUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Room")]
    [IsoXmlTag("Room")]
    public ValueList<LodgingRoom2> Room { get; init; } = [];

    /// <summary>
    /// Duration of stay in days.
    /// </summary>
    [IsoId("_UfdhZ0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public IsoMax4NumericText? Duration { get; init; }

    /// <summary>
    /// Lodging transaction details.
    /// </summary>
    [IsoId("_UfdhaUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Arrival")]
    [IsoXmlTag("Arrvl")]
    public DepartureOrArrival2? Arrival { get; init; }

    /// <summary>
    /// Contains departure details.
    /// </summary>
    [IsoId("_Ufdha0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Departure")]
    [IsoXmlTag("Dprture")]
    public DepartureOrArrival1? Departure { get; init; }

    /// <summary>
    /// Indicates that the cardholder failed to arrive at the property and was therefore charged a no-show fee.
    /// </summary>
    [IsoId("_X7CLEUh-EfCMZJtj4J7UGQ")]
    [DisplayName("No Show")]
    [IsoXmlTag("NoShow")]
    public IsoTrueFalseIndicator? NoShow { get; init; }

    /// <summary>
    /// Indicates whether or not insurance was purchased.
    /// </summary>
    [IsoId("_Ufdhb0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Insurance")]
    [IsoXmlTag("Insrnc")]
    public IsoTrueFalseIndicator? Insurance { get; init; }

    /// <summary>
    /// Amount of insurance.
    /// </summary>
    [IsoId("_UfdhcUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Insurance Amount")]
    [IsoXmlTag("InsrncAmt")]
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; }

    /// <summary>
    /// Taxes related to the products or services.
    /// </summary>
    [IsoId("_Ufdhc0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Total Tax")]
    [IsoXmlTag("TtlTax")]
    public ValueList<Tax44> TotalTax { get; init; } = [];

    /// <summary>
    /// Contains the total amount of lodging expenses.
    /// </summary>
    [IsoId("_UfdhdUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Contains authorised amount details.
    /// </summary>
    [IsoId("_Ufdhd0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Authorised Amount")]
    [IsoXmlTag("AuthrsdAmt")]
    public ValueList<AuthorisedAmount2> AuthorisedAmount { get; init; } = [];

    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_UfdheUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Loyalty programme details.
    /// </summary>
    [IsoId("_Ufdhe0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Loyalty Programme")]
    [IsoXmlTag("LltyPrgrmm")]
    public ValueList<LoyaltyProgramme4> LoyaltyProgramme { get; init; } = [];

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_MvlrgkhsEfCMZJtj4J7UGQ")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_Mvlrg0hsEfCMZJtj4J7UGQ")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];

    /// <summary>
    /// Component provides detailed information about lodging accommodations and related expenses for the cardholder.
    /// </summary>
    [IsoId("_Ufdhf0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public ValueList<LodgingLineItem4> LineItem { get; init; } = [];
}
