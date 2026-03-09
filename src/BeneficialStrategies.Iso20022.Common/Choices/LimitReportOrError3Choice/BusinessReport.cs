// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.LimitReportOrError3Choice
{
    /// <summary>
    /// Reports on limits.
    /// </summary>
    [IsoId("_Q1IWIZlhEeeE1Ya-LgRsuQ")]
    [DisplayName("Business Report")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record BusinessReport : LimitReportOrError3Choice_
    #else
    public partial class BusinessReport : LimitReportOrError3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Report is given for a current risk management type limit.
        /// </summary>
        [IsoId("_RDVxQ5lhEeeE1Ya-LgRsuQ")]
        [DisplayName("Current Limit")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CurLmt")]
        #endif
        [IsoXmlTag("CurLmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public LimitReport6? CurrentLimit { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public LimitReport6? CurrentLimit { get; init; } 
        #else
        public LimitReport6? CurrentLimit { get; set; } 
        #endif
        
        /// <summary>
        /// Report is given for a default risk management type limit.
        /// </summary>
        [IsoId("_RDVxRZlhEeeE1Ya-LgRsuQ")]
        [DisplayName("Default Limit")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DfltLmt")]
        #endif
        [IsoXmlTag("DfltLmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public LimitReport6? DefaultLimit { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public LimitReport6? DefaultLimit { get; init; } 
        #else
        public LimitReport6? DefaultLimit { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
