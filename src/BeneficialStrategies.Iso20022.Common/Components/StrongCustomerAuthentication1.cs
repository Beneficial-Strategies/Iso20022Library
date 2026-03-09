// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// EU PSD2 Strong Consumer Authentication data.
/// </summary>
[IsoId("_umTNkAMfEeujMs2LsB3mMw")]
[DisplayName("Strong Customer Authentication")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StrongCustomerAuthentication1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Boolean flag indicating whether the transaction is subject to Strong Customer Authentication requirements (True) or not (False).
    /// </summary>
    [IsoId("_6dGccAMfEeujMs2LsB3mMw")]
    [DisplayName("Subject To SCA")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbjtToSCA")]
    #endif
    [IsoXmlTag("SbjtToSCA")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? SubjectToSCA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubjectToSCA { get; init; } 
    #else
    public System.String? SubjectToSCA { get; set; } 
    #endif
    
    /// <summary>
    /// Strong customer authentication exemption detail.
    /// </summary>
    [IsoId("_gEuy0AMlEeujMs2LsB3mMw")]
    [DisplayName("Exemption")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xmptn")]
    #endif
    [IsoXmlTag("Xmptn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Exemption1? Exemption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Exemption1? Exemption { get; init; } 
    #else
    public Exemption1? Exemption { get; set; } 
    #endif
    
    /// <summary>
    /// Authentication performed by a delegated authority (for example by a wallet solution).
    /// </summary>
    [IsoId("_5g2V8AMnEeubkNI1IXQTVQ")]
    [DisplayName("Delegated Authority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlgtdAuthrty")]
    #endif
    [IsoXmlTag("DlgtdAuthrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AttestationValue1Code? DelegatedAuthority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AttestationValue1Code? DelegatedAuthority { get; init; } 
    #else
    public AttestationValue1Code? DelegatedAuthority { get; set; } 
    #endif
    
    /// <summary>
    /// Waiver claimed for a transaction subject to Strong Customer Authentication.
    /// </summary>
    [IsoId("_DuufMAMoEeubkNI1IXQTVQ")]
    [DisplayName("Waiver")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Wvr")]
    #endif
    [IsoXmlTag("Wvr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AttestationValue1Code? Waiver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AttestationValue1Code? Waiver { get; init; } 
    #else
    public AttestationValue1Code? Waiver { get; set; } 
    #endif
    
    /// <summary>
    /// Reason why authentication was not performed.
    /// </summary>
    [IsoId("_PuZWMAMoEeubkNI1IXQTVQ")]
    [DisplayName("Reason Authentication Not Performed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsnAuthntcnNotPrfrmd")]
    #endif
    [IsoXmlTag("RsnAuthntcnNotPrfrmd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4Text? ReasonAuthenticationNotPerformed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReasonAuthenticationNotPerformed { get; init; } 
    #else
    public System.String? ReasonAuthenticationNotPerformed { get; set; } 
    #endif
    
    
    #nullable disable
    
}
