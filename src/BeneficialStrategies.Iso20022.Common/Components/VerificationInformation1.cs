// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains verification information.
/// </summary>
[IsoId("_SSs6A9ImEeirx-13kKhDlQ")]
[DisplayName("Verification Information")]
public partial record VerificationInformation1
{
    #nullable enable
    
    /// <summary>
    /// Type of the verification or authentication.
    /// ISO 8583:2003 bit 34
    /// </summary>
    [IsoId("_SSthENImEeirx-13kKhDlQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; } 
    
    /// <summary>
    /// Value of the data to be verified or authenticated.
    /// </summary>
    [IsoId("_SSthEdImEeirx-13kKhDlQ")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public VerificationValue1Choice_? Value { get; init; } 
    
    /// <summary>
    /// Reason to perform the verification.
    /// </summary>
    [IsoId("_DDFDQdIoEeirx-13kKhDlQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Reason { get; init; } 
    
    /// <summary>
    /// Date and time when the verification was performed.
    /// </summary>
    [IsoId("__IV3sGzVEemD24gVaMSpeA")]
    [DisplayName("Date Time")]
    [IsoXmlTag("DtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? DateTime { get; init; } 
    
    /// <summary>
    /// Contains end date of the verification that has been performed. 
    /// </summary>
    [IsoId("_akg48GzWEemD24gVaMSpeA")]
    [DisplayName("Validity End Date")]
    [IsoXmlTag("VldtyEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValidityEndDate { get; init; } 
    
    /// <summary>
    /// Contains end time of the verification that has been performed. 
    /// </summary>
    [IsoId("_OOdrgHC2EemD24gVaMSpeA")]
    [DisplayName("Validity End Time")]
    [IsoXmlTag("VldtyEndTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? ValidityEndTime { get; init; } 
    
    
    #nullable disable
    
}
