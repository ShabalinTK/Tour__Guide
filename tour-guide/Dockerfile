# This is the newer version

FROM node:22 AS build

WORKDIR /app

COPY package*.json ./

RUN npm i
RUN npm i -g serve

COPY . .

# Build the app
RUN npm run build

EXPOSE 3000

CMD [ "serve", "-s", "dist" ]