import os
import tweepy
import argparse

# parse all arguments
parser = argparse.ArgumentParser()
parser.add_argument('--API_KEY', help='apikey')
parser.add_argument('--API_SECRET', help='apisecret')
parser.add_argument('--ACCESS_TOKEN', help='accesstoken')
parser.add_argument('--ACCESS_SECRET', help='accesssecret')
parser.add_argument('--TWEET', help='tweet', nargs='?')
parser.add_argument('--IMG', help='imgfile', nargs='?')
parser.add_argument('--IMG_URL', help='imgurl', nargs='?')
parser.add_argument('--BEARER', help='bearertoken', nargs='?')
args = parser.parse_args()

# set variables
API_KEY=args.API_KEY
API_SECRET=args.API_SECRET
ACCESS_TOKEN=args.ACCESS_TOKEN
ACCESS_SECRET=args.ACCESS_SECRET
BEARER_TOKEN=args.BEARER
TWEET=args.TWEET
IMG_FILE=args.IMG
IMG_URL=args.IMG_URL
MEDIA_ID=None

# declare functions
def upload_tweet_media(media_path):
    auth = tweepy.OAuth1UserHandler(
        API_KEY,
        API_SECRET,
        ACCESS_TOKEN,
        ACCESS_SECRET
    )
    api = tweepy.API(auth)
    media = api.media_upload(filename=media_path)
    return [media.media_id_string]

def tweet_text(message):
    client = tweepy.Client(
        consumer_key=API_KEY,
        consumer_secret=API_SECRET,
        access_token=ACCESS_TOKEN,
        access_token_secret=ACCESS_SECRET
    )
    tweet = client.create_tweet(text=message)

def tweet_text_and_media(message, media_id):
    client = tweepy.Client(
        consumer_key=API_KEY,
        consumer_secret=API_SECRET,
        access_token=ACCESS_TOKEN,
        access_token_secret=ACCESS_SECRET
    )
    tweet = client.create_tweet(text=message,media_ids=media_id)

def tweet_media(media_id):
    client = tweepy.Client(
        consumer_key=API_KEY,
        consumer_secret=API_SECRET,
        access_token=ACCESS_TOKEN,
        access_token_secret=ACCESS_SECRET
    )
    tweet = client.create_tweet(media_ids=media_id)

# image check
if IMG_FILE is not None:
    MEDIA_ID=upload_tweet_media(media_path=IMG_FILE)

if IMG_URL is not None:
    MEDIA_ID=upload_tweet_media(media_path=IMG_URL)

# main execution
# Check 1 -> message and media
if MEDIA_ID is not None and TWEET is not None:
    # Code to execute if both conditions are True
    print("MEDIA_ID and TWEET published")
    tweet_text_and_media(message=TWEET,media_id=MEDIA_ID)

# Check 2 - message only
if MEDIA_ID is None and TWEET is not None:
    # Code to execute if only the second condition is True
    print("TWEET is published")
    tweet_text(message=TWEET)

# Check 3 - media only
if MEDIA_ID is not None and TWEET is None:
    # Code to execute if only the first condition is True
    print("MEDIA_ID is published")
    tweet_media(media_id=MEDIA_ID)