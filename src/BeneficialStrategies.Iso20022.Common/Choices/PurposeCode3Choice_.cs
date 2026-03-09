// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and or a data source scheme to determine the account type.
    /// </summary>
    [KnownType(typeof(PurposeCode3Choice.Code))]
    [KnownType(typeof(PurposeCode3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PurposeCode3Choice.Code),nameof(PurposeCode3Choice.Code))]
    [JsonDerivedType(typeof(PurposeCode3Choice.Proprietary),nameof(PurposeCode3Choice.Proprietary))]
    #endif
    [IsoId("_XN-Akdp-Ed-ak6NoX_4Aeg_-1420247134")]
    [DisplayName("Purpose Code 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PurposeCode3Choice_
    #else
    public abstract partial class PurposeCode3Choice_
    #endif
    {
    }
}
