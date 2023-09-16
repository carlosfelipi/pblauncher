/*
 Navicat Premium Data Transfer

 Source Server         : 726B9F4A15A087531308B50ED3B1EDCD
 Source Server Type    : PostgreSQL
 Source Server Version : 90525
 Source Host           : localhost:5501
 Source Catalog        : postgres
 Source Schema         : public

 Target Server Type    : PostgreSQL
 Target Server Version : 90525
 File Encoding         : 65001

 Date: 04/07/2023 16:10:47
*/


-- ----------------------------
-- Table structure for web_launcher
-- ----------------------------
DROP TABLE IF EXISTS "public"."web_launcher";
CREATE TABLE "public"."web_launcher" (
  "launcherColor" varchar(255) COLLATE "pg_catalog"."default",
  "launcherVer" varchar(255) COLLATE "pg_catalog"."default",
  "status" int4,
  "message" text COLLATE "pg_catalog"."default",
  "webAnnounce" varchar(500) COLLATE "pg_catalog"."default",
  "webRanking" varchar(500) COLLATE "pg_catalog"."default",
  "webBrowser" bool DEFAULT true,
  "urlFiles" varchar(500) COLLATE "pg_catalog"."default",
  "urlUpdate" varchar(500) COLLATE "pg_catalog"."default",
  "urlRapair" varchar(500) COLLATE "pg_catalog"."default",
  "urlRegister" varchar(500) COLLATE "pg_catalog"."default",
  "urlDiscord" varchar(500) COLLATE "pg_catalog"."default",
  "urlFacebook" varchar(500) COLLATE "pg_catalog"."default",
  "urlYoutube" varchar(500) COLLATE "pg_catalog"."default",
  "urlSite" varchar(500) COLLATE "pg_catalog"."default",
  "userFileList" varchar(500) COLLATE "pg_catalog"."default",
  "clientVer" varchar(500) COLLATE "pg_catalog"."default",
  "regeDit" varchar(500) COLLATE "pg_catalog"."default",
  "codeAccess" varchar(500) COLLATE "pg_catalog"."default"
)
;

-- ----------------------------
-- Records of web_launcher
-- ----------------------------
INSERT INTO "public"."web_launcher" VALUES ('#0000FF', '0.0.0.1', 3, 'dsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssdsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssdsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssdsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssdsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssdsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssdsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssdsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssdsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssdsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssdsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssdsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssdsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssdsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssdsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssdsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssdsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssdsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssdsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssdsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssdsssssssssssssssssssssssssssssssssssssssssssssssssssssssssss', '0', '0', 't', 'http://development-area.sd/public/files/', 'http://development-area.sd/public/updates/', '0', '0', '0', 'https://www.facebook.com/', '0', '0', '0', '0', 'pbfive_key', '4B2AF156899AD3E0C90D90A785BA09CB80E78E085905A40AD6937647');

-- ----------------------------
-- Table structure for web_launcher_hwid
-- ----------------------------
DROP TABLE IF EXISTS "public"."web_launcher_hwid";
CREATE TABLE "public"."web_launcher_hwid" (
  "hwid" varchar(10000) COLLATE "pg_catalog"."default" NOT NULL,
  "status" bool DEFAULT true
)
;

-- ----------------------------
-- Records of web_launcher_hwid
-- ----------------------------
INSERT INTO "public"."web_launcher_hwid" VALUES ('82b45204-5fde-4afb-9b90-88e7d0524863', 't');

-- ----------------------------
-- Primary Key structure for table web_launcher_hwid
-- ----------------------------
ALTER TABLE "public"."web_launcher_hwid" ADD CONSTRAINT "web_launcher_hwid_pkey" PRIMARY KEY ("hwid");
