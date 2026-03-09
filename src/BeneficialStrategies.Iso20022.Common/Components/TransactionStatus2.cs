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
[IsoId("_Ut7swNp-Ed-ak6NoX_4Aeg_97707535")]
[DisplayName("Transaction Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionStatus2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionStatus2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionStatus2( BaselineStatus1Code reqStatus,System.DateTime reqChangeDateTime )
    {
        Status = reqStatus;
        ChangeDateTime = reqChangeDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_Ut7swdp-Ed-ak6NoX_4Aeg_157735099")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BaselineStatus1Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BaselineStatus1Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BaselineStatus1Code Status { get; init; } 
    #else
    public BaselineStatus1Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the current status will change.
    /// </summary>
    [IsoId("_Ut7swtp-Ed-ak6NoX_4Aeg_185440156")]
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
    
    
    #nullable disable
    
}
