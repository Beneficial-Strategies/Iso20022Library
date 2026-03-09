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
namespace BeneficialStrategies.Iso20022.Choices.CurrentOrDefaultReservation3Choice
{
    /// <summary>
    /// Identification of the current reservation.
    /// </summary>
    [IsoId("_hBG6UdcZEeqRFcf2R4bPBw")]
    [DisplayName("Current")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Current : CurrentOrDefaultReservation3Choice_
    #else
    public partial class Current : CurrentOrDefaultReservation3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Current instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Current( ReservationType2Choice_ reqType )
        {
            Type = reqType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identification of the reservation.
        /// </summary>
        [IsoId("_eMNw0dcZEeqRFcf2R4bPBw")]
        [DisplayName("Reservation Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RsvatnId")]
        #endif
        [IsoXmlTag("RsvatnId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? ReservationIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ReservationIdentification { get; init; } 
        #else
        public System.String? ReservationIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of a particular cash clearing system.
        /// </summary>
        [IsoId("_eMNw09cZEeqRFcf2R4bPBw")]
        [DisplayName("System Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SysId")]
        #endif
        [IsoXmlTag("SysId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SystemIdentification2Choice_? SystemIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SystemIdentification2Choice_? SystemIdentification { get; init; } 
        #else
        public SystemIdentification2Choice_? SystemIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Nature of the reservation.
        /// </summary>
        [IsoId("_eMNw1dcZEeqRFcf2R4bPBw")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ReservationType2Choice_ Type { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ReservationType2Choice_ Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReservationType2Choice_ Type { get; init; } 
        #else
        public ReservationType2Choice_ Type { get; set; } 
        #endif
        
        /// <summary>
        /// Owner of the account which is being queried.
        /// </summary>
        [IsoId("_eMNw19cZEeqRFcf2R4bPBw")]
        [DisplayName("Account Owner")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctOwnr")]
        #endif
        [IsoXmlTag("AcctOwnr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; init; } 
        #else
        public BranchAndFinancialInstitutionIdentification6? AccountOwner { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_eMNw2dcZEeqRFcf2R4bPBw")]
        [DisplayName("Account Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AcctId")]
        #endif
        [IsoXmlTag("AcctId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public AccountIdentification4Choice_? AccountIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public AccountIdentification4Choice_? AccountIdentification { get; init; } 
        #else
        public AccountIdentification4Choice_? AccountIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
