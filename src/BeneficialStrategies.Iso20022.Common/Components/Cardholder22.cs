// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cardholder22.
/// </summary>
[IsoId("_B1kYEXG2Ee60F8I8TAMKmg")]
[DisplayName("Cardholder22")]
public partial record Cardholder22
{
    #nullable enable

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Address.
    /// </summary>
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; } 

    /// <summary>
    /// Contact Information.
    /// </summary>
    [DisplayName("Contact Information")]
    [IsoXmlTag("CtctInf")]
    public ContactPersonal1? ContactInformation { get; init; } 

    /// <summary>
    /// Date Of Birth.
    /// </summary>
    [DisplayName("Date Of Birth")]
    [IsoXmlTag("DtOfBirth")]
    public IsoISODate? DateOfBirth { get; init; } 

    /// <summary>
    /// High Value.
    /// </summary>
    [DisplayName("High Value")]
    [IsoXmlTag("HghVal")]
    public IsoTrueFalseIndicator? HighValue { get; init; } 

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public ValueList<Credentials3> Identification { get; init; } = [];

    /// <summary>
    /// Local Data.
    /// </summary>
    [DisplayName("Local Data")]
    [IsoXmlTag("LclData")]
    public LocalData13? LocalData { get; init; } 

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public CardholderName3? Name { get; init; } 

    
    #nullable disable
    
}
