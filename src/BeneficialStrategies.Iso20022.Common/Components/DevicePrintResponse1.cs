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
/// Content of the Print Response message.
/// </summary>
[IsoId("_Ty4bQN7HEeiwsev40qZGEQ")]
[DisplayName("Device Print Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DevicePrintResponse1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DevicePrintResponse1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DevicePrintResponse1( DocumentType7Code reqDocumentQualifier )
    {
        DocumentQualifier = reqDocumentQualifier;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Qualification of the document printed to the Cashier or the Customer.
    /// </summary>
    [IsoId("_ckZUMN7HEeiwsev40qZGEQ")]
    [DisplayName("Document Qualifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocQlfr")]
    #endif
    [IsoXmlTag("DocQlfr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentType7Code DocumentQualifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentType7Code DocumentQualifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentType7Code DocumentQualifier { get; init; } 
    #else
    public DocumentType7Code DocumentQualifier { get; set; } 
    #endif
    
    
    #nullable disable
    
}
