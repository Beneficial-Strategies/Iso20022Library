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
/// Information about the notification of the termination of an undertaking.
/// </summary>
[IsoId("_97ufHHltEeG7BsjMvd1mEw_-864278160")]
[DisplayName("Undertaking Termination Notice")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingTerminationNotice1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UndertakingTerminationNotice1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UndertakingTerminationNotice1( Undertaking9 reqUndertakingIdentification,UndertakingTermination3 reqTerminationDetails )
    {
        UndertakingIdentification = reqUndertakingIdentification;
        TerminationDetails = reqTerminationDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Details related to the identification of the undertaking.
    /// </summary>
    [IsoId("_974QEHltEeG7BsjMvd1mEw_1656167276")]
    [DisplayName("Undertaking Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgId")]
    #endif
    [IsoXmlTag("UdrtkgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Undertaking9 UndertakingIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Undertaking9 UndertakingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Undertaking9 UndertakingIdentification { get; init; } 
    #else
    public Undertaking9 UndertakingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the termination of the undertaking.
    /// </summary>
    [IsoId("_974QEXltEeG7BsjMvd1mEw_1055156994")]
    [DisplayName("Termination Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnDtls")]
    #endif
    [IsoXmlTag("TermntnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingTermination3 TerminationDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UndertakingTermination3 TerminationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingTermination3 TerminationDetails { get; init; } 
    #else
    public UndertakingTermination3 TerminationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Document or template enclosed in the termination notification.
    /// </summary>
    [IsoId("_974QE3ltEeG7BsjMvd1mEw_1574400589")]
    [DisplayName("Enclosed File")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NclsdFile")]
    #endif
    [IsoXmlTag("NclsdFile")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Document9? EnclosedFile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Document9? EnclosedFile { get; init; } 
    #else
    public Document9? EnclosedFile { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the notification.
    /// </summary>
    [IsoId("_974QFHltEeG7BsjMvd1mEw_1143129336")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
