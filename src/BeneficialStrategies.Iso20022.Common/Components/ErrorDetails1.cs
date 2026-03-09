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
/// Details of the error
/// </summary>
[IsoId("_BixN8ccuEeiYIbmhB2-RrQ")]
[DisplayName("Error Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ErrorDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ErrorDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ErrorDetails1( MessageError1Code reqMessageErrorType )
    {
        MessageErrorType = reqMessageErrorType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Code list containing a code that identifies the error condition.
    /// </summary>
    [IsoId("_nOwFsPGtEeiGNursv3uE_g")]
    [DisplayName("Message Error Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgErrTp")]
    #endif
    [IsoXmlTag("MsgErrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageError1Code MessageErrorType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageError1Code MessageErrorType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageError1Code MessageErrorType { get; init; } 
    #else
    public MessageError1Code MessageErrorType { get; set; } 
    #endif
    
    /// <summary>
    /// Other message error type defined at national or private level.
    /// </summary>
    [IsoId("_sd_xwPGtEeiGNursv3uE_g")]
    [DisplayName("Other Message Error Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrMsgErrTp")]
    #endif
    [IsoXmlTag("OthrMsgErrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherMessageErrorType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherMessageErrorType { get; init; } 
    #else
    public System.String? OtherMessageErrorType { get; set; } 
    #endif
    
    /// <summary>
    /// Error code defined in ISO 8583:2003 table A.10 Message error codes (bit 18). 
    /// </summary>
    [IsoId("_Sw4i8McyEeiYIbmhB2-RrQ")]
    [DisplayName("Error Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ErrCd")]
    #endif
    [IsoXmlTag("ErrCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ErrorCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ErrorCode { get; init; } 
    #else
    public System.String? ErrorCode { get; set; } 
    #endif
    
    /// <summary>
    /// Other Message Error Code. 
    /// </summary>
    [IsoId("_ZavL0McyEeiYIbmhB2-RrQ")]
    [DisplayName("Error Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ErrDesc")]
    #endif
    [IsoXmlTag("ErrDesc")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax500Text? ErrorDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ErrorDescription { get; init; } 
    #else
    public System.String? ErrorDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Data element in error. 
    /// </summary>
    [IsoId("_uYYqcMcyEeiYIbmhB2-RrQ")]
    [DisplayName("Data Element In Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataElmtInErr")]
    #endif
    [IsoXmlTag("DataElmtInErr")]
    [IsoSimpleType(IsoSimpleType.Max4000Text)]
    [StringLength(maximumLength: 4000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4000Text? DataElementInError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DataElementInError { get; init; } 
    #else
    public System.String? DataElementInError { get; set; } 
    #endif
    
    
    #nullable disable
    
}
