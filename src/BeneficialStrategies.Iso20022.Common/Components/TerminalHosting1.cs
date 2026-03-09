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
/// Entity hosting the ATM terminal.
/// </summary>
[IsoId("_gJenIIn2EeS9F4Qrq_eaVA")]
[DisplayName("Terminal Hosting")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TerminalHosting1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of ATM terminal hosting.
    /// </summary>
    [IsoId("_uyiiQIn2EeS9F4Qrq_eaVA")]
    [DisplayName("Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctgy")]
    #endif
    [IsoXmlTag("Ctgy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionEnvironment3Code? Category { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionEnvironment3Code? Category { get; init; } 
    #else
    public TransactionEnvironment3Code? Category { get; set; } 
    #endif
    
    /// <summary>
    /// Identify the entity hosting the ATM.
    /// </summary>
    [IsoId("_8G24AIn2EeS9F4Qrq_eaVA")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
