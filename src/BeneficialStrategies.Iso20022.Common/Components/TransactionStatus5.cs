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
/// Identifies the future status of the transaction by means of a code and a period.
/// </summary>
[IsoId("_RbFb9Np-Ed-ak6NoX_4Aeg_-2036389843")]
[DisplayName("Transaction Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionStatus5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionStatus5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionStatus5( BaselineStatus3Code reqStatus,System.DateTime reqChangeDateTime )
    {
        Status = reqStatus;
        ChangeDateTime = reqChangeDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_RbFb9dp-Ed-ak6NoX_4Aeg_-2036389841")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BaselineStatus3Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BaselineStatus3Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BaselineStatus3Code Status { get; init; } 
    #else
    public BaselineStatus3Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the current status will change.
    /// </summary>
    [IsoId("_RbFb9tp-Ed-ak6NoX_4Aeg_-2036389782")]
    [DisplayName("Change Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChngDtTm")]
    #endif
    [IsoXmlTag("ChngDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime ChangeDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime ChangeDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime ChangeDateTime { get; init; } 
    #else
    public System.DateTime ChangeDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information on the reason for the time-out.
    /// </summary>
    [IsoId("_RbFb99p-Ed-ak6NoX_4Aeg_-149402521")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    
    #nullable disable
    
}
