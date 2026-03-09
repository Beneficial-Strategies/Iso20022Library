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
/// Specifies the extended parameters for an Isabel payment file.
/// </summary>
[IsoId("_AfkC0KA3EeWiJt5KdX5iuQ")]
[DisplayName("Isabel Extended Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IsabelExtendedHeader1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// SEPA related information for a payment file.
    /// </summary>
    [IsoId("_BZu2wMmREeWAGphE2LvqeA")]
    [DisplayName("SEPA")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SEPA")]
    #endif
    [IsoXmlTag("SEPA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsabelSEPAFile1? SEPA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IsabelSEPAFile1? SEPA { get; init; } 
    #else
    public IsabelSEPAFile1? SEPA { get; set; } 
    #endif
    
    /// <summary>
    /// Belgian bank protocol number (BPN) of the receiving bank.
    /// </summary>
    [IsoId("_IBl7kMmREeWAGphE2LvqeA")]
    [DisplayName("BPN Financial Institution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BPNFI")]
    #endif
    [IsoXmlTag("BPNFI")]
    [IsoSimpleType(IsoSimpleType.Max3Text)]
    [StringLength(maximumLength: 3 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3Text? BPNFinancialInstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BPNFinancialInstitution { get; init; } 
    #else
    public System.String? BPNFinancialInstitution { get; set; } 
    #endif
    
    /// <summary>
    /// Business identification code of the receiving bank.
    /// </summary>
    [IsoId("_NbCsgMmREeWAGphE2LvqeA")]
    [DisplayName("BIC Financial Institution")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BICFI")]
    #endif
    [IsoXmlTag("BICFI")]
    [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBICFIIdentifier? BICFinancialInstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BICFinancialInstitution { get; init; } 
    #else
    public System.String? BICFinancialInstitution { get; set; } 
    #endif
    
    
    #nullable disable
    
}
