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
[IsoId("_vz7UwIIJEeS7UOLM47txvA")]
[DisplayName("Transaction Verification Result")]
public partial record TransactionVerificationResult4
{
    #nullable enable
    
    /// <summary>
    /// Method of verification that has been performed.
    /// </summary>
    [IsoId("_wAAB4YIJEeS7UOLM47txvA")]
    [DisplayName("Method")]
    [IsoXmlTag("Mtd")]
    public required AuthenticationMethod6Code Method { get; init; } 
    
    /// <summary>
    /// Entity or device that has performed the verification.
    /// </summary>
    [IsoId("_wAAB44IJEeS7UOLM47txvA")]
    [DisplayName("Verification Entity")]
    [IsoXmlTag("VrfctnNtty")]
    public AuthenticationEntity2Code? VerificationEntity { get; init; } 
    
    /// <summary>
    /// Result of the verification.
    /// </summary>
    [IsoId("_wAAB5YIJEeS7UOLM47txvA")]
    [DisplayName("Result")]
    [IsoXmlTag("Rslt")]
    public Verification1Code? Result { get; init; } 
    
    /// <summary>
    /// Additional result of the verification.
    /// </summary>
    [IsoId("_wAAB54IJEeS7UOLM47txvA")]
    [DisplayName("Additional Result")]
    [IsoXmlTag("AddtlRslt")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public IsoMax500Text? AdditionalResult { get; init; } 
    
    
    #nullable disable
    
}
