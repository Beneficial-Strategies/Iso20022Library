// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vehicle Rental Service3.
/// </summary>
[IsoId("_pYqlQXTfEe6h-4AZRg9sVg")]
[DisplayName("Vehicle Rental Service3")]
public partial record VehicleRentalService3
{
    #nullable enable

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Additional Driver.
    /// </summary>
    [DisplayName("Additional Driver")]
    [IsoXmlTag("AddtlDrvr")]
    public ValueList<DriverInParty3> AdditionalDriver { get; init; } = [];

    /// <summary>
    /// Company Address.
    /// </summary>
    [DisplayName("Company Address")]
    [IsoXmlTag("CpnyAdr")]
    public Address2? CompanyAddress { get; init; } 

    /// <summary>
    /// Company Contact.
    /// </summary>
    [DisplayName("Company Contact")]
    [IsoXmlTag("CpnyCtct")]
    public ContactBusiness1? CompanyContact { get; init; } 

    /// <summary>
    /// Company Identification.
    /// </summary>
    [DisplayName("Company Identification")]
    [IsoXmlTag("CpnyId")]
    public PartyIdentification285? CompanyIdentification { get; init; } 

    /// <summary>
    /// Company Name.
    /// </summary>
    [DisplayName("Company Name")]
    [IsoXmlTag("CpnyNm")]
    public IsoMax70Text? CompanyName { get; init; } 

    /// <summary>
    /// Company Other Type.
    /// </summary>
    [DisplayName("Company Other Type")]
    [IsoXmlTag("CpnyOthrTp")]
    public IsoMax35Text? CompanyOtherType { get; init; } 

    /// <summary>
    /// Company Type.
    /// </summary>
    [DisplayName("Company Type")]
    [IsoXmlTag("CpnyTp")]
    public CarRentalActivity1Code? CompanyType { get; init; } 

    /// <summary>
    /// Loyalty Programme.
    /// </summary>
    [DisplayName("Loyalty Programme")]
    [IsoXmlTag("LltyPrgrmm")]
    public LoyaltyProgramme4? LoyaltyProgramme { get; init; } 

    /// <summary>
    /// Primary Driver.
    /// </summary>
    [DisplayName("Primary Driver")]
    [IsoXmlTag("PmryDrvr")]
    public DriverInParty3? PrimaryDriver { get; init; } 

    /// <summary>
    /// Rental Agreement.
    /// </summary>
    [DisplayName("Rental Agreement")]
    [IsoXmlTag("RntlAgrmt")]
    public VehicleRentalAgreement3? RentalAgreement { get; init; } 

    /// <summary>
    /// Rental Invoice.
    /// </summary>
    [DisplayName("Rental Invoice")]
    [IsoXmlTag("RntlInvc")]
    public VehicleRentalInvoice3? RentalInvoice { get; init; } 

    /// <summary>
    /// Renter Corporate Identifier.
    /// </summary>
    [DisplayName("Renter Corporate Identifier")]
    [IsoXmlTag("RntrCorpIdr")]
    public required IsoMax35Text RenterCorporateIdentifier { get; init; } 

    /// <summary>
    /// Renter Corporate Identifier Assigner.
    /// </summary>
    [DisplayName("Renter Corporate Identifier Assigner")]
    [IsoXmlTag("RntrCorpIdrAssgnr")]
    public CustomerAssigner1Code? RenterCorporateIdentifierAssigner { get; init; } 

    /// <summary>
    /// Renter Corporate Name.
    /// </summary>
    [DisplayName("Renter Corporate Name")]
    [IsoXmlTag("RntrCorpNm")]
    public IsoMax70Text? RenterCorporateName { get; init; } 

    /// <summary>
    /// Renter Name.
    /// </summary>
    [DisplayName("Renter Name")]
    [IsoXmlTag("RntrNm")]
    public required IsoMax70Text RenterName { get; init; } 

    /// <summary>
    /// Summary Commodity Identification.
    /// </summary>
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; } 

    
    #nullable disable
    
}
