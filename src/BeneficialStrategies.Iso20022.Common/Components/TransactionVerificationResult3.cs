// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Result of performed verifications for the transaction.
/// </summary>
[IsoId("_0RdhAWjkEeSDR-pyia6Xtg")]
[DisplayName("Transaction Verification Result")]
public partial record TransactionVerificationResult3
{
    #nullable enable
    
    /// <summary>
    /// Method of verification that has been used.
    /// </summary>
    [IsoId("_9Ax6MGjnEeSDR-pyia6Xtg")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    public required AuthenticationMethod4Code Method { get; init; } 
    
    /// <summary>
    /// Entity or device that has performed the verification.
    /// </summary>
    [IsoId("_P9FMIGjoEeSDR-pyia6Xtg")]
    [DisplayName("Verification Entity")]
    [IsoXmlTag("VrfctnNtty")]
    public AuthenticationEntity2Code? VerificationEntity { get; init; } 
    
    /// <summary>
    /// Result of the verification.
    /// </summary>
    [IsoId("_BiJXIGjpEeSDR-pyia6Xtg")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public Verification1Code? Result { get; init; } 
    
    /// <summary>
    /// Additional result of the verification.
    /// </summary>
    [IsoId("_EP4vwGjpEeSDR-pyia6Xtg")]
    [DisplayName("Additional Result")]
    [IsoXmlTag("AddtlRslt")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? AdditionalResult { get; init; } 
    
    
    #nullable disable
    
}
