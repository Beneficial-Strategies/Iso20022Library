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
/// Application specific information defined by the service provider.
/// </summary>
[IsoId("_jLluUe5NEeCisYr99QEiWA_17771453")]
[DisplayName("Application Specifics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ApplicationSpecifics1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ApplicationSpecifics1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ApplicationSpecifics1( System.UInt64 reqTotalNumberOfDocuments )
    {
        TotalNumberOfDocuments = reqTotalNumberOfDocuments;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// A system user is a user account defined in the static data. It represents an individual or an application that interacts with the system administrator (e. g. T2S), triggering the available functions. The set of functions available to each system user stems from the set of privileges for which the system user is grantee. System administrator does not provide any attribute for distinguishing between individuals and applications. 
    /// </summary>
    [IsoId("_hdq1QWliEeGaMcKyqKNRfQ_64695608")]
    [DisplayName("System User")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysUsr")]
    #endif
    [IsoXmlTag("SysUsr")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? SystemUser { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SystemUser { get; init; } 
    #else
    public System.String? SystemUser { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the digital signature of the Business Entity authorised to sign this Business File.
    /// </summary>
    [IsoId("_hdq1QmliEeGaMcKyqKNRfQ_1022556874")]
    [DisplayName("Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sgntr")]
    #endif
    [IsoXmlTag("Sgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SignatureEnvelope? Signature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignatureEnvelope? Signature { get; init; } 
    #else
    public SignatureEnvelope? Signature { get; set; } 
    #endif
    
    /// <summary>
    /// Gives the total number of instances (messages) within the file.
    /// </summary>
    [IsoId("_jLluUu5NEeCisYr99QEiWA_1016478772")]
    [DisplayName("Total Number Of Documents")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfDocs")]
    #endif
    [IsoXmlTag("TtlNbOfDocs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber TotalNumberOfDocuments { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 TotalNumberOfDocuments { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 TotalNumberOfDocuments { get; init; } 
    #else
    public System.UInt64 TotalNumberOfDocuments { get; set; } 
    #endif
    
    
    #nullable disable
    
}
