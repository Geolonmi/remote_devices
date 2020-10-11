var path = require("path");
var webpack = require("webpack");

module.exports = {
  devtool: "eval-source-map",
  mode: "development",
  entry: "./src/",
  output: {
    path: path.join(__dirname, "../ENDPOINT/remote_device_api/wwwroot/js"),
    filename: "index.js",
    publicPath: "js/",
  },
  resolve: {
    extensions: [".js", ".ts", ".tsx"],
  },
  module: {
    rules: [
      {
        test: /\.tsx?$/,
        loader: "awesome-typescript-loader",
        include: path.join(__dirname, "src"),
      },
      {
        test: /(\.css$)/,
        loaders: ["style-loader", "css-loader"],
      },
    ],
  },
};
