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
/// Details of the document entry amendment.
/// </summary>
[IsoId("_rOYIcLP4Eeud-ZmjZVm7MA")]
[DisplayName("Document Entry Amendment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DocumentEntryAmendment1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DocumentEntryAmendment1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DocumentEntryAmendment1( System.UInt64 reqCorrectingEntryNumber,DocumentIdentification28 reqOriginalDocument )
    {
        CorrectingEntryNumber = reqCorrectingEntryNumber;
        OriginalDocument = reqOriginalDocument;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of correcting entry.
    /// </summary>
    [IsoId("_DlxxILP5Eeud-ZmjZVm7MA")]
    [DisplayName("Correcting Entry Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrrctgNtryNb")]
    #endif
    [IsoXmlTag("CrrctgNtryNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber CorrectingEntryNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 CorrectingEntryNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 CorrectingEntryNumber { get; init; } 
    #else
    public System.UInt64 CorrectingEntryNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to an original document.
    /// </summary>
    [IsoId("_MnAhELP5Eeud-ZmjZVm7MA")]
    [DisplayName("Original Document")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlDoc")]
    #endif
    [IsoXmlTag("OrgnlDoc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification28 OriginalDocument { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification28 OriginalDocument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification28 OriginalDocument { get; init; } 
    #else
    public DocumentIdentification28 OriginalDocument { get; set; } 
    #endif
    
    
    #nullable disable
    
}
