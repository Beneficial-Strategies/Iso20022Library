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
    /// Choice of an EU dividen status type.
    /// </summary>
    [KnownType(typeof(EUDividendStatusType1Choice.EUDividendStatus))]
    [KnownType(typeof(EUDividendStatusType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EUDividendStatusType1Choice.EUDividendStatus),nameof(EUDividendStatusType1Choice.EUDividendStatus))]
    [JsonDerivedType(typeof(EUDividendStatusType1Choice.Proprietary),nameof(EUDividendStatusType1Choice.Proprietary))]
    #endif
    [IsoId("_RgcdEtp-Ed-ak6NoX_4Aeg_-1297197608")]
    [DisplayName("EU Dividend Status Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EUDividendStatusType1Choice_
    #else
    public abstract partial class EUDividendStatusType1Choice_
    #endif
    {
    }
}
