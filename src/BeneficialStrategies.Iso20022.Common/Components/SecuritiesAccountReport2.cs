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
/// Set of elements used to report information about securities account reference data.
/// </summary>
[IsoId("_t8qdteGEEeWCAvUNsZ5u6g")]
[DisplayName("Securities Account Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesAccountReport2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesAccountReport2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesAccountReport2( SecuritiesAccount19 reqSecuritiesAccountIdentification,SecuritiesAccountOrBusinessError2Choice_ reqSecuritiesAccountOrError )
    {
        SecuritiesAccountIdentification = reqSecuritiesAccountIdentification;
        SecuritiesAccountOrError = reqSecuritiesAccountOrError;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    [IsoId("_uIaaseGEEeWCAvUNsZ5u6g")]
    [DisplayName("Securities Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesAcctId")]
    #endif
    [IsoXmlTag("SctiesAcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount19 SecuritiesAccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccount19 SecuritiesAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19 SecuritiesAccountIdentification { get; init; } 
    #else
    public SecuritiesAccount19 SecuritiesAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the returned securities account reference data or error information.
    /// </summary>
    [IsoId("_uIaas-GEEeWCAvUNsZ5u6g")]
    [DisplayName("Securities Account Or Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesAcctOrErr")]
    #endif
    [IsoXmlTag("SctiesAcctOrErr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccountOrBusinessError2Choice_ SecuritiesAccountOrError { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccountOrBusinessError2Choice_ SecuritiesAccountOrError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccountOrBusinessError2Choice_ SecuritiesAccountOrError { get; init; } 
    #else
    public SecuritiesAccountOrBusinessError2Choice_ SecuritiesAccountOrError { get; set; } 
    #endif
    
    
    #nullable disable
    
}
