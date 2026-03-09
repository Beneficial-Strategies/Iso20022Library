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
namespace BeneficialStrategies.Iso20022.Choices.InvestigationResult1Choice
{
    /// <summary>
    /// Provides the investigation status.
    /// </summary>
    [IsoId("_elyCtGgkEeGHuf0_3c6vdw")]
    [DisplayName("Investigation Status")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record InvestigationStatus : InvestigationResult1Choice_
    #else
    public partial class InvestigationStatus : InvestigationResult1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a InvestigationStatus instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public InvestigationStatus( InvestigationStatus1Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Provides the status of the investigation response related to a previously sent request.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="InvstgtnSts")]
        #endif
        [IsoXmlTag("InvstgtnSts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required InvestigationStatus1Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required InvestigationStatus1Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InvestigationStatus1Code Value { get; init; } 
        #else
        public InvestigationStatus1Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
