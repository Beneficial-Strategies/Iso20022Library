// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security Identification47.
/// </summary>
[IsoId("_yH8W0W2-Ee6KsPNq-miPbQ")]
[DisplayName("Security Identification47")]
public partial record SecurityIdentification47
{
    #nullable enable

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];

    /// <summary>
    /// Base Currency.
    /// </summary>
    [DisplayName("Base Currency")]
    [IsoXmlTag("BaseCcy")]
    public ActiveCurrencyCode? BaseCurrency { get; init; } 

    /// <summary>
    /// Classification Type.
    /// </summary>
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public SecurityClassificationType2Choice_? ClassificationType { get; init; } 

    /// <summary>
    /// Class Type.
    /// </summary>
    [DisplayName("Class Type")]
    [IsoXmlTag("ClssTp")]
    public IsoMax35Text? ClassType { get; init; } 

    /// <summary>
    /// Country Of Domicile.
    /// </summary>
    [DisplayName("Country Of Domicile")]
    [IsoXmlTag("CtryOfDmcl")]
    public CountryCode? CountryOfDomicile { get; init; } 

    /// <summary>
    /// Ex Post Cost Calculation Basis.
    /// </summary>
    [DisplayName("Ex Post Cost Calculation Basis")]
    [IsoXmlTag("ExPstCostClctnBsis")]
    public ExPostCostCalculationBasis1Choice_? ExPostCostCalculationBasis { get; init; } 

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification40 Identification { get; init; } 

    /// <summary>
    /// Issuer.
    /// </summary>
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public ContactAttributes5? Issuer { get; init; } 

    /// <summary>
    /// Issuer Product Governance Process.
    /// </summary>
    [DisplayName("Issuer Product Governance Process")]
    [IsoXmlTag("IssrPdctGovncPrc")]
    public GovernanceProcess1Choice_? IssuerProductGovernanceProcess { get; init; } 

    /// <summary>
    /// Leveraged Or Contingent Liability.
    /// </summary>
    [DisplayName("Leveraged Or Contingent Liability")]
    [IsoXmlTag("LvrgdOrCntngntLblty")]
    public IsoYesNoIndicator? LeveragedOrContingentLiability { get; init; } 

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public required IsoMax350Text Name { get; init; } 

    /// <summary>
    /// New Umbrella.
    /// </summary>
    [DisplayName("New Umbrella")]
    [IsoXmlTag("NewUmbrll")]
    public IsoYesNoIndicator? NewUmbrella { get; init; } 

    /// <summary>
    /// No Retrocession Indicator.
    /// </summary>
    [DisplayName("No Retrocession Indicator")]
    [IsoXmlTag("NoRtrcssnInd")]
    public IsoYesNoIndicator? NoRetrocessionIndicator { get; init; } 

    /// <summary>
    /// Notional Or Unit Based.
    /// </summary>
    [DisplayName("Notional Or Unit Based")]
    [IsoXmlTag("NtnlOrUnitBased")]
    public NotionalOrUnitBased1Choice_? NotionalOrUnitBased { get; init; } 

    /// <summary>
    /// Product Category.
    /// </summary>
    [DisplayName("Product Category")]
    [IsoXmlTag("PdctCtgy")]
    public IsoMax140Text? ProductCategory { get; init; } 

    /// <summary>
    /// Product Category Germany.
    /// </summary>
    [DisplayName("Product Category Germany")]
    [IsoXmlTag("PdctCtgyDE")]
    public IsoMax140Text? ProductCategoryGermany { get; init; } 

    /// <summary>
    /// Product Type.
    /// </summary>
    [DisplayName("Product Type")]
    [IsoXmlTag("PdctTp")]
    public ProductStructure1Choice_? ProductType { get; init; } 

    /// <summary>
    /// Quotation Type.
    /// </summary>
    [DisplayName("Quotation Type")]
    [IsoXmlTag("QtnTp")]
    public QuotationType1Choice_? QuotationType { get; init; } 

    /// <summary>
    /// Registered Distribution Country.
    /// </summary>
    [DisplayName("Registered Distribution Country")]
    [IsoXmlTag("RegdDstrbtnCtry")]
    public ValueList<CountryCode> RegisteredDistributionCountry { get; init; } = [];

    /// <summary>
    /// Short Name.
    /// </summary>
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    public IsoMax35Text? ShortName { get; init; } 

    /// <summary>
    /// Umbrella Name.
    /// </summary>
    [DisplayName("Umbrella Name")]
    [IsoXmlTag("UmbrllNm")]
    public IsoMax35Text? UmbrellaName { get; init; } 

    
    #nullable disable
    
}
