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
namespace BeneficialStrategies.Iso20022.Choices.Quantity43Choice
{
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_qCevQa5xEeeMy7TnJ3e__g")]
    [DisplayName("Unit")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Unit : Quantity43Choice_
    #else
    public partial class Unit : Quantity43Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Unit instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Unit( System.UInt64 reqTotalUnitsNumber )
        {
            TotalUnitsNumber = reqTotalUnitsNumber;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Quantity expressed as a number, for example, a number of shares.
        /// </summary>
        [IsoId("_6zRy8a5xEeeMy7TnJ3e__g")]
        [DisplayName("Total Units Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TtlUnitsNb")]
        #endif
        [IsoXmlTag("TtlUnitsNb")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoDecimalNumber TotalUnitsNumber { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.UInt64 TotalUnitsNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64 TotalUnitsNumber { get; init; } 
        #else
        public System.UInt64 TotalUnitsNumber { get; set; } 
        #endif
        
        /// <summary>
        /// Information about the units to be transferred.
        /// </summary>
        [IsoId("_6zRy865xEeeMy7TnJ3e__g")]
        [DisplayName("Unit Details")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UnitDtls")]
        #endif
        [IsoXmlTag("UnitDtls")]
        [MinLength(0)]
        [MaxLength(2)]
        public ValueList<Unit10> UnitDetails { get; init; } = new ValueList<Unit10>(){};
        
        
        #nullable disable
        
    }
}
