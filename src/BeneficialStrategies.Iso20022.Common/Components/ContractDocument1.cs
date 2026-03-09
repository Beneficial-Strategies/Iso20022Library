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
/// Document that contains the information of the contract agreed between both parties.
/// </summary>
[IsoId("_UkjHQtp-Ed-ak6NoX_4Aeg_15886237")]
[DisplayName("Contract Document")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContractDocument1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ContractDocument1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ContractDocument1( System.String reqReference )
    {
        Reference = reqReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Account contract established between the organisation or the group to which the organisation belongs, and the account servicer. This contract has to be applied for the new account to be opened and maintained.
    /// </summary>
    [IsoId("_UkjHQ9p-Ed-ak6NoX_4Aeg_392681280")]
    [DisplayName("Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ref")]
    #endif
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Reference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Reference { get; init; } 
    #else
    public System.String Reference { get; set; } 
    #endif
    
    /// <summary>
    /// Signoff date of the document.
    /// </summary>
    [IsoId("_UkjHRNp-Ed-ak6NoX_4Aeg_564641730")]
    [DisplayName("Sign Off Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgnOffDt")]
    #endif
    [IsoXmlTag("SgnOffDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? SignOffDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? SignOffDate { get; init; } 
    #else
    public System.DateOnly? SignOffDate { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the version of the contract.
    /// </summary>
    [IsoId("_UkjHRdp-Ed-ak6NoX_4Aeg_618206750")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax6Text? Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Version { get; init; } 
    #else
    public System.String? Version { get; set; } 
    #endif
    
    
    #nullable disable
    
}
