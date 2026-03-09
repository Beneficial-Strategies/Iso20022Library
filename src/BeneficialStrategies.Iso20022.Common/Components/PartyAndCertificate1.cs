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
/// Entity involved in an activity.
/// </summary>
[IsoId("_PXDuuNp-Ed-ak6NoX_4Aeg_818704056")]
[DisplayName("Party And Certificate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyAndCertificate1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyAndCertificate1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyAndCertificate1( PartyIdentification41 reqParty,Authorisation1 reqAuthorisation )
    {
        Party = reqParty;
        Authorisation = reqAuthorisation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_PXM4oNp-Ed-ak6NoX_4Aeg_2106416666")]
    [DisplayName("Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pty")]
    #endif
    [IsoXmlTag("Pty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification41 Party { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification41 Party { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification41 Party { get; init; } 
    #else
    public PartyIdentification41 Party { get; set; } 
    #endif
    
    /// <summary>
    /// Security certificate used to sign electronically.
    /// </summary>
    [IsoId("_PXM4odp-Ed-ak6NoX_4Aeg_1578430719")]
    [DisplayName("Certificate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cert")]
    #endif
    [IsoXmlTag("Cert")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10KBinary? Certificate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? Certificate { get; init; } 
    #else
    public System.Byte[]? Certificate { get; set; } 
    #endif
    
    /// <summary>
    /// Order in which the mandate holder has to sign.
    /// </summary>
    [IsoId("_PXM4otp-Ed-ak6NoX_4Aeg_880566094")]
    [DisplayName("Signature Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgntrOrdr")]
    #endif
    [IsoXmlTag("SgntrOrdr")]
    [IsoSimpleType(IsoSimpleType.Max15PlusSignedNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15PlusSignedNumericText? SignatureOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SignatureOrder { get; init; } 
    #else
    public System.String? SignatureOrder { get; set; } 
    #endif
    
    /// <summary>
    /// Authorisation granted to a mandate holder.
    /// </summary>
    [IsoId("_PXM4o9p-Ed-ak6NoX_4Aeg_637414510")]
    [DisplayName("Authorisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Authstn")]
    #endif
    [IsoXmlTag("Authstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Authorisation1 Authorisation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Authorisation1 Authorisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Authorisation1 Authorisation { get; init; } 
    #else
    public Authorisation1 Authorisation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
