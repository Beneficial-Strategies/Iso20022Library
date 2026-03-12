// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of verifications performed prior or after the transaction.
/// </summary>
[IsoId("_T2ITcEbXEeeIjf8aP9KbJA")]
[DisplayName("Verification Result")]
public partial record VerificationResult1
{
    #nullable enable
    
    /// <summary>
    /// Type of the verification or authentication.
    /// </summary>
    [IsoId("_jrPy0dIpEeirx-13kKhDlQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; } 
    
    /// <summary>
    /// Entity who actually performed the verification.
    /// ISO 8583:93 bit 22-9
    /// </summary>
    [IsoId("_BUFgIBZSEeiwvuY-sPnsNg")]
    [DisplayName("Entity")]
    [IsoXmlTag("Ntty")]
    public VerificationEntity1Code? Entity { get; init; } 
    
    /// <summary>
    /// Other national or private entity in charge of the verification.
    /// </summary>
    [IsoId("_JXcSkBZSEeiwvuY-sPnsNg")]
    [DisplayName("Other Entity")]
    [IsoXmlTag("OthrNtty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherEntity { get; init; } 
    
    /// <summary>
    /// Result of the verification.
    /// ISO 8583 : 2003 bit 49 dataset 72
    /// </summary>
    [IsoId("_pP-l4EbXEeeIjf8aP9KbJA")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public Verification2Code? Result { get; init; } 
    
    /// <summary>
    /// Additional result of the verification, for instance for electronic commerce.
    /// </summary>
    [IsoId("_qoTDsEbXEeeIjf8aP9KbJA")]
    [DisplayName("Other Result")]
    [IsoXmlTag("OthrRslt")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? OtherResult { get; init; } 
    
    /// <summary>
    /// Details of the result.
    /// </summary>
    [IsoId("_7lzGoEbXEeeIjf8aP9KbJA")]
    [DisplayName("Result Details")]
    [IsoXmlTag("RsltDtls")]
    public AdditionalData1? ResultDetails { get; init; } 
    
    
    #nullable disable
    
}
