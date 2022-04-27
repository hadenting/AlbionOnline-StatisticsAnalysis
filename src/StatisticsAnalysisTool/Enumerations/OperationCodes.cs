﻿namespace StatisticsAnalysisTool.Enumerations
{
    public enum OperationCodes
    {
        Unused = 0,
        Ping,
        Join,
        CreateAccount,
        Login,
        SendCrashLog,
        SendTraceRoute,
        SendVfxStats,
        SendGamePingInfo,
        CreateCharacter,
        DeleteCharacter,
        SelectCharacter,
        RedeemKeycode,
        GetGameServerByCluster,
        GetActiveSubscription,
        GetShopPurchaseUrl,
        GetBuyTrialDetails,
        GetReferralSeasonDetails,
        GetReferralLink,
        GetAvailableTrialKeys,
        GetShopTilesForCategory,
        Move = 22,
        AttackStart,
        CastStart,
        CastCancel,
        TerminateToggleSpell,
        ChannelingCancel,
        AttackBuildingStart,
        InventoryDestroyItem,
        InventoryMoveItem = 30, // map[0:4 1:[39 -87 28 -11 -124 -89 51 72 -111 -18 117 74 87 91 -56 72] 2:14 4:[39 -87 28 -11 -124 -89 51 72 -111 -18 117 74 87 91 -56 72] 5:14 253:29]
        InventoryRecoverItem,
        InventoryRecoverAllItems,
        InventorySplitStack,
        InventorySplitStackInto,
        GetClusterData,
        ChangeCluster = 35,
        ConsoleCommand,
        ChatMessage,
        ReportClientError,
        RegisterToObject,
        UnRegisterFromObject,
        CraftBuildingChangeSettings,
        CraftBuildingTakeMoney,
        RepairBuildingChangeSettings,
        RepairBuildingTakeMoney,
        ActionBuildingChangeSettings,
        HarvestStart,
        HarvestCancel,
        TakeSilver,
        ActionOnBuildingStart,
        ActionOnBuildingCancel,
        ItemRerollQualityStart,
        ItemRerollQualityCancel,
        InstallResourceStart,
        InstallResourceCancel,
        InstallSilver,
        BuildingFillNutrition,
        BuildingChangeRenovationState,
        BuildingBuySkin,
        BuildingClaim,
        BuildingGiveup,
        BuildingNutritionSilverStorageDeposit,
        BuildingNutritionSilverStorageWithdraw,
        BuildingNutritionSilverRewardSet,
        ConstructionSiteCreate,
        PlaceableObjectPlace,
        PlaceableObjectPlaceCancel,
        PlaceableObjectPickup,
        FurnitureObjectUse,
        FarmableHarvest,
        FarmableFinishGrownItem,
        FarmableDestroy,
        FarmableGetProduct,
        FarmableFill,
        TearDownConstructionSite,
        CastleGateUse,
        AuctionCreateOffer,
        AuctionCreateRequest,
        AuctionGetOffers,
        AuctionGetRequests,
        AuctionBuyOffer,
        AuctionAbortAuction,
        AuctionModifyAuction,
        AuctionAbortOffer,
        AuctionAbortRequest,
        AuctionSellRequest,
        AuctionGetFinishedAuctions,
        AuctionGetFinishedAuctionsCount,
        AuctionFetchAuction,
        AuctionGetMyOpenOffers,
        AuctionGetMyOpenRequests,
        AuctionGetMyOpenAuctions,
        AuctionGetItemAverageStats,
        AuctionGetItemAverageValue,
        ContainerOpen = 92, // map[0: ObjectId = 405 1:1 2: ObjectGuid = [-46 37 -21 125 -40 -77 125 76 -96 -6 39 120 -46 -21 11 -39] 253:92]
        ContainerClose,
        ContainerManageSubContainer,
        Respawn,
        Suicide,
        JoinGuild,
        LeaveGuild,
        CreateGuild,
        InviteToGuild,
        DeclineGuildInvitation,
        KickFromGuild,
        DuellingChallengePlayer,
        DuellingAcceptChallenge,
        DuellingDenyChallenge,
        ChangeClusterTax,
        ClaimTerritory,
        GiveUpTerritory,
        ChangeTerritoryAccessRights,
        GetMonolithInfo,
        GetClaimInfo,
        GetAttackInfo,
        GetTerritorySeasonPoints,
        GetAttackSchedule,
        ScheduleAttack,
        GetMatches,
        GetMatchDetails,
        JoinMatch,
        LeaveMatch,
        ChangeChatSettings,
        LogoutStart,
        LogoutCancel,
        ClaimOrbStart,
        ClaimOrbCancel,
        MatchLootChestOpeningStart,
        MatchLootChestOpeningCancel,
        DepositToGuildAccount,
        WithdrawalFromAccount,
        ChangeGuildPayUpkeepFlag,
        ChangeGuildTax,
        GetMyTerritories,
        MorganaCommand,
        GetServerInfo,
        InviteMercenaryToMatch,
        SubscribeToCluster,
        AnswerMercenaryInvitation,
        GetCharacterEquipment,
        GetCharacterSteamAchievements,
        GetCharacterStats,
        GetKillHistoryDetails,
        LearnMasteryLevel,
        ReSpecAchievement,
        ChangeAvatar,
        GetRankings,
        GetRank,
        GetGvgSeasonRankings,
        GetGvgSeasonRank,
        GetGvgSeasonHistoryRankings,
        GetGvgSeasonGuildMemberHistory,
        KickFromGvGMatch,
        GetChestLogs,
        GetAccessRightLogs,
        GetGuildAccountLogs,
        GetGuildAccountLogsLargeAmount,
        InviteToPlayerTrade,
        PlayerTradeCancel,
        PlayerTradeInvitationAccept,
        PlayerTradeAddItem,
        PlayerTradeRemoveItem,
        PlayerTradeAcceptTrade,
        PlayerTradeSetSilverOrGold,
        SendMiniMapPing,
        Stuck,
        BuyRealEstate,
        ClaimRealEstate,
        GiveUpRealEstate,
        ChangeRealEstateOutline,
        GetMailInfos = 168, // map[0:- 2:0 3:[MAIL_ID, MAIL_ID] 4:- 5:- 6:[CLUSTER_ID or UserName] 7:[3 3] 8:[3 3] 9:[true true]
                            // 10:[MARKETPLACE_BUYORDER_FINISHED_SUMMARY MARKETPLACE_SELLORDER_FINISHED_SUMMARY] 11:[637852747555964630 637852641241345990] 12:[false false]]
        GetMailCount,
        ReadMail = 170, //  map[0: MailId 1:QUANTITY|UNIQUE_ITEM_NAME(T4_ARMOR_CLOTH_SET3)|TOTAL_PRICE|UNIT_PRICE 2:[] 3:[] 4:[] 5:[] 6:[] 253:170]
        SendNewMail,
        DeleteMail,
        MarkMailUnread,
        ClaimAttachmentFromMail,
        UpdateLfgInfo,
        GetLfgInfos,
        GetMyGuildLfgInfo,
        GetLfgDescriptionText,
        LfgApplyToGuild,
        AnswerLfgGuildApplication,
        RegisterChatPeer,
        SendChatMessage,
        JoinChatChannel,
        LeaveChatChannel,
        SendWhisperMessage,
        Say,
        PlayEmote,
        StopEmote,
        GetClusterMapInfo,
        AccessRightsChangeSettings,
        Mount,
        MountCancel,
        BuyJourney,
        SetSaleStatusForEstate,
        ResolveGuildOrPlayerName,
        GetRespawnInfos,
        MakeHome,
        LeaveHome,
        ResurrectionReply,
        AllianceCreate,
        AllianceDisband,
        AllianceGetMemberInfos,
        AllianceInvite,
        AllianceAnswerInvitation,
        AllianceCancelInvitation,
        AllianceKickGuild,
        AllianceLeave,
        AllianceChangeGoldPaymentFlag,
        AllianceGetDetailInfo,
        GetIslandInfos,
        AbandonMyIsland,
        BuyMyIsland,
        BuyGuildIsland,
        AbandonGuildIsland,
        UpgradeMyIsland,
        UpgradeGuildIsland,
        MoveMyIsland,
        MoveGuildIsland,
        TerritoryFillNutrition,
        TeleportBack,
        PartyInvitePlayer,
        PartyAnswerInvitation,
        PartyLeave,
        PartyKickPlayer,
        PartyMakeLeader = 222,
        PartyChangeLootSetting,
        PartyMarkObject,
        PartySetRole,
        GetGuildMotd,
        ExitEnterStart,
        ExitEnterCancel,
        QuestGiverRequest,
        GoldMarketGetBuyOffer,
        GoldMarketGetBuyOfferFromSilver,
        GoldMarketGetSellOffer,
        GoldMarketGetSellOfferFromSilver,
        GoldMarketBuyGold,
        GoldMarketSellGold,
        GoldMarketCreateSellOrder,
        GoldMarketCreateBuyOrder,
        GoldMarketGetInfos,
        GoldMarketCancelOrder,
        Unknown246,
        GoldMarketGetAverageInfo,
        SiegeCampClaimStart,
        SiegeCampClaimCancel,
        TreasureChestUsingStart,
        TreasureChestUsingCancel,
        UseLootChest, // <- LootLogger: https://github.com/EmeraldKnight79/AO-DU-LootLogger/blob/b1ab099e0d82bdee0a87c153f4bbae324295656e/LootLogger/PacketHandler.cs#L68
        UseShrine = 248,
        LaborerStartJob,
        LaborerTakeJobLoot,
        LaborerDismiss,
        LaborerMove,
        LaborerBuyItem,
        LaborerUpgrade,
        BuyPremium,
        BuyTrial,
        RealEstateGetAuctionData,
        RealEstateBidOnAuction,
        GetSiegeCampCooldown,
        FriendInvite,
        FriendAnswerInvitation,
        FriendCancelnvitation,
        FriendRemove,
        InventoryStack,
        InventorySort,
        EquipmentItemChangeSpell,
        ExpeditionRegister,
        ExpeditionRegisterCancel,
        JoinExpedition,
        DeclineExpeditionInvitation,
        VoteStart,
        VoteDoVote,
        RatingDoRate,
        EnteringExpeditionStart,
        EnteringExpeditionCancel,
        ActivateExpeditionCheckPoint,
        ArenaRegister,
        ArenaRegisterCancel,
        ArenaLeave,
        JoinArenaMatch,
        DeclineArenaInvitation,
        EnteringArenaStart,
        EnteringArenaCancel,
        ArenaCustomMatch,
        ArenaCustomMatchCreate,
        UpdateCharacterStatement,
        BoostFarmable,
        GetStrikeHistory,
        UseFunction,
        UsePortalEntrance,
        ResetPortalBinding,
        QueryPortalBinding,
        ClaimPaymentTransaction,
        ChangeUseFlag,
        ClientPerformanceStats,
        ExtendedHardwareStats = 300, //  map[0:NVIDIA GeForce RTX 3090 1:AMD Ryzen 7 2700X Eight-Core Processor  2:Windows 10  (10.0.0) 64bit 3:3693 4:24348 5:16293 6:DE-DE 7:Custom 8:1746 10:-1 253:303]
        ClientLowMemoryWarning,
        TerritoryClaimStart,
        TerritoryClaimCancel,
        RequestAppStoreProducts,
        VerifyProductPurchase,
        QueryGuildPlayerStats,
        QueryAllianceGuildStats,
        TrackAchievements,
        SetAchievementsAutoLearn,
        DepositItemToGuildCurrency,
        WithdrawalItemFromGuildCurrency,
        AuctionSellSpecificItemRequest,
        FishingStart,
        FishingCasting,
        FishingCast,
        FishingCatch,
        FishingPull,
        FishingGiveLine,
        FishingFinish,
        FishingCancel,
        CreateGuildAccessTag,
        DeleteGuildAccessTag,
        RenameGuildAccessTag,
        FlagGuildAccessTagGuildPermission,
        AssignGuildAccessTag,
        RemoveGuildAccessTagFromPlayer,
        ModifyGuildAccessTagEditors,
        RequestPublicAccessTags,
        ChangeAccessTagPublicFlag,
        UpdateGuildAccessTag,
        SteamStartMicrotransaction,
        SteamFinishMicrotransaction,
        SteamIdHasActiveAccount,
        CheckEmailAccountState,
        LinkAccountToSteamId,
        BuyGvgSeasonBooster,
        ChangeFlaggingPrepare,
        OverCharge,
        OverChargeEnd,
        RequestTrusted,
        ChangeGuildLogo,
        PartyFinderRegisterForUpdates,
        PartyFinderUnregisterForUpdates,
        PartyFinderEnlistNewPartySearch,
        PartyFinderDeletePartySearch,
        PartyFinderChangePartySearch,
        PartyFinderChangeRole,
        PartyFinderApplyForGroup,
        PartyFinderAcceptOrDeclineApplyForGroup,
        PartyFinderGetEquipmentSnapshot,
        PartyFinderRegisterApplicants,
        PartyFinderUnregisterApplicants,
        PartyFinderFulltextSearch,
        PartyFinderRequestEquipmentSnapshot,
        GetPersonalSeasonTrackerData,
        UseConsumableFromInventory,
        ClaimPersonalSeasonReward,
        EasyAntiCheatMessageToServer,
        SetNextTutorialState,
        AddPlayerToMuteList,
        RemovePlayerFromMuteList,
        ProductShopUserEvent,
        GetVanityUnlocks,
        BuyVanityUnlocks,
        GetMountSkins,
        SetMountSkin,
        SetWardrobe,
        ChangeCustomization,
        SetFavoriteIsland,
        GetGuildChallengePoints,
        TravelToHideout,
        SmartQueueJoin,
        SmartQueueLeave,
        SmartQueueSelectSpawnCluster,
        UpgradeHideout,
        InitHideoutAttackStart,
        InitHideoutAttackCancel,
        HideoutFillNutrition,
        HideoutGetInfo,
        HideoutGetOwnerInfo,
        HideoutSetTribute,
        OpenWorldAttackScheduleStart,
        OpenWorldAttackScheduleCancel,
        OpenWorldAttackConquerStart,
        OpenWorldAttackConquerCancel,
        GetOpenWorldAttackDetails,
        GetNextOpenWorldAttackScheduleTime,
        RecoverVaultFromHideout,
        GetGuildEnergyDrainInfo,
        ChannelingUpdate,
        Unknown394,
        Unknown395,
        Unknown396,
        Unknown397,
        Unknown398,
        Unknown399,
        Unknown400,
        OpenItemWindow,
    }
}